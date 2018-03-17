using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RavageStaminaIngredientPriority : EffectIngredientPriority<RavageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.Deathbell, 10},
            {AllIngredients.Bee, 0},
            {AllIngredients.BeritsAshes, 0},
            {AllIngredients.BoneMeal, 0},
            {AllIngredients.Honeycomb, 0},
            {AllIngredients.ThistleBranch, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}