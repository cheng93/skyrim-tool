using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RestoreHealthIngredientPriority : EffectIngredientPriority<RestoreAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BlueDartwing, 0},
            {AllIngredients.BlueMountainFlower, 0},
            {AllIngredients.ButterflyWing, 0},
            {AllIngredients.CharredSkeeverHide, 0},
            {AllIngredients.DaedraHeart, 0},
            {AllIngredients.EyeOfSabreCat, 0},
            {AllIngredients.RockWarblerEgg, 0},
            {AllIngredients.SwampFungalPod, 0},
            {AllIngredients.Wheat, 0},
            {AllIngredients.Blisterwort, -10},
            {AllIngredients.ImpStool, -10}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}