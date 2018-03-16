using System.Collections.Generic;
using Rpg.Models.Alchemy;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy
{
    public interface IPotionBuilder
    {
        IPotion Build();

        IPotionBuilder Ingredient(IIngredient ingredient);

        IPotionBuilder Perk(IPerk<AlchemySkill> perk);
    }

    public class PotionBuilder : IPotionBuilder
    {
        public PotionBuilder(IPotionFactory potionFactory)
        {
            this.potionFactory = potionFactory;
        }

        private IAlchemyOptions alchemyOptions = new AlchemyOptions();

        private List<IIngredient> ingredients = new List<IIngredient>();

        private List<IPerk<AlchemySkill>> perks = new List<IPerk<AlchemySkill>>();

        private readonly IPotionFactory potionFactory;

        public IPotion Build()
        {
            alchemyOptions.Ingredients = ingredients;
            alchemyOptions.Perks = perks;
            return potionFactory.Create(alchemyOptions);
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
    }
}