using System;
using System.Collections.Generic;
using System.Linq;
using Rpg.Logic.Alchemy.EffectIngredientPriorities;
using Rpg.Logic.Alchemy.Formulas;
using Rpg.Models.Alchemy;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Perks.Alchemy;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy
{
    internal interface IPotionFactory
    {
        IPotion Create(IAlchemyOptions options);
    }

    internal class PotionFactory : IPotionFactory
    {
        public PotionFactory(
            IEffectIngredientPriorityFactory effectIngredientPriorityFactory,
            IAlchemyFormulae alchemyFormulae,
            IAlchemyEffectFactory alchemyEffectFactory)
        {
            this.alchemyFormulae = alchemyFormulae;
            this.alchemyEffectFactory = alchemyEffectFactory;
            this.effectIngredientPriorityFactory = effectIngredientPriorityFactory;
        }

        private readonly IAlchemyFormulae alchemyFormulae;

        private readonly IEffectIngredientPriorityFactory effectIngredientPriorityFactory;

        private readonly IAlchemyEffectFactory alchemyEffectFactory;

        public IPotion Create(IAlchemyOptions options)
        {
            var commonEffects = options.Ingredients
                .SelectMany(
                    x => x.CombinedEffects,
                    (x, effect) => new
                    {
                        Ingredient = x,
                        Effect = effect
                    })
                .GroupBy(x => x.Effect.Id)
                .Where(x => x.Count() > 1)
                .Select(x => x
                    .OrderByDescending(y => effectIngredientPriorityFactory
                        .Create(y.Effect)
                        .GetPriority(y.Ingredient))
                    .First()
                    .Effect);

            if (commonEffects.Count() == 0)
            {
                return null;
            }

            var processedEffects = commonEffects
                .Select(x => new
                {
                    Effect = x,
                    Results = alchemyFormulae.GetResults(x, options)
                })
                .OrderByDescending(x => x.Results.BaseCost)
                .ThenBy(x => x.Effect.Name)
                .AsEnumerable();

            var mainEffect = processedEffects.First();

            var hasPurityPerk = HasPurityPerk(options.Perks);

            if (hasPurityPerk)
            {
                processedEffects = processedEffects.Where(x => x.Effect.IsPositiveEffect == mainEffect.Effect.IsPositiveEffect);
            }

            var potionEffects = processedEffects
                .Select(x => alchemyEffectFactory.Create(
                    x.Effect,
                    x.Results.Cost,
                    x.Results.Duration,
                    x.Results.Magnitude));

            var potionName = mainEffect.Effect.IsPositiveEffect
                ? $"Potion of {mainEffect.Effect.Name}"
                : $"Poison of {mainEffect.Effect.Name}";

            return new Potion(potionEffects, potionName);
        }

        private bool HasPurityPerk(IEnumerable<IPerk<AlchemySkill>> perks) => perks.OfType<PurityPerk>().Any();
    }
}
