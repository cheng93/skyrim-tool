using System.Collections.Generic;
using FluentValidation;
using Rpg.Models.Alchemy;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy
{
    public interface IPotionBuilder
    {
        IPotionBuilder AlchemyLevel(int alchemyLevel);

        IPotionBuilder FortifyAlchemyPercent(decimal fortifyAlchemyPercent);

        IPotionBuilder Ingredient(IIngredient ingredient);

        IPotionBuilder Perk(IPerk<AlchemySkill> perk);

        IValidatedPotionBuilder Validate();
    }

    public interface IValidatedPotionBuilder
    {
        IPotion Build();
    }

    internal class PotionBuilder : IPotionBuilder
    {
        public PotionBuilder(IPotionFactory potionFactory, IAlchemyOptionsValidator validator)
        {
            this.potionFactory = potionFactory;
            this.validator = validator;
        }

        private IAlchemyOptions alchemyOptions = new AlchemyOptions();

        private List<IIngredient> ingredients = new List<IIngredient>();

        private List<IPerk<AlchemySkill>> perks = new List<IPerk<AlchemySkill>>();

        private readonly IPotionFactory potionFactory;

        private readonly IAlchemyOptionsValidator validator;

        public IPotionBuilder AlchemyLevel(int alchemyLevel)
        {
            alchemyOptions.AlchemyLevel = alchemyLevel;
            return this;
        }

        public IPotionBuilder FortifyAlchemyPercent(decimal fortifyAlchemyPercent)
        {
            alchemyOptions.FortifyAlchemyPercent = fortifyAlchemyPercent;
            return this;
        }

        public IPotionBuilder Ingredient(IIngredient ingredient)
        {
            ingredients.Add(ingredient);
            return this;
        }

        public IPotionBuilder Perk(IPerk<AlchemySkill> perk)
        {
            perks.Add(perk);
            return this;
        }

        public IValidatedPotionBuilder Validate()
        {
            alchemyOptions.Ingredients = ingredients;
            alchemyOptions.Perks = perks;
            validator.ValidateAndThrow(alchemyOptions);
            return new ValidatedPotionBuilder(potionFactory, alchemyOptions);
        }
    }

    internal class ValidatedPotionBuilder : IValidatedPotionBuilder
    {
        public ValidatedPotionBuilder(IPotionFactory potionFactory, IAlchemyOptions options)
        {
            this.options = options;
            this.potionFactory = potionFactory;
        }

        private readonly IAlchemyOptions options;

        private readonly IPotionFactory potionFactory;

        public IPotion Build()
        {
            return potionFactory.Create(options);
        }
    }
}