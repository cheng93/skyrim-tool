using System;
using System.Collections.Generic;
using System.Linq;
using Rpg.Models.Alchemy;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks.Alchemy;

namespace Rpg.Logic.Alchemy
{
    internal interface IPotionFactory
    {
        IPotion Create(IAlchemyOptions options);
    }

    internal class PotionFactory : IPotionFactory
    {
        public IPotion Create(IAlchemyOptions options)
        {
            var commonEffects = options.Ingredients
                .SelectMany(
                    x => x.CombinedEffects,
                    (x, effect) => new {
                        Ingredient = x,
                        Effect = effect
                    })
                .GroupBy(x => x.Effect)
                .Where(x => x.Count() > 1)
                .ToDictionary(
                    x => x.Key,
                    x => x.First().Ingredient);

            if (commonEffects.Count == 0)
            {
                return null;
            }

            throw new NotImplementedException();
        }
    }
}