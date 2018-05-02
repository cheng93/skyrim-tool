using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyHealthIngredientPriority : EffectIngredientPriority<FortifyAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.GiantsToe, 10},
            {AllIngredients.BearClaws, 0},
            {AllIngredients.BlueMountainFlower, 0},
            {AllIngredients.GlowingMushroom, 0},
            {AllIngredients.HangingMoss, 0},
            {AllIngredients.Wheat, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}