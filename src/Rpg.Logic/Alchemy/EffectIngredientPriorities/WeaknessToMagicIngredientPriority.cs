using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class WeaknessToMagicIngredientPriority : EffectIngredientPriority<WeaknessToMagicAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.CreepCluster, 0},
            {AllIngredients.DwarvenOil, 0},
            {AllIngredients.JazbayGrapes, 0},
            {AllIngredients.RockWarblerEgg, 0},
            {AllIngredients.SaltPile, 0},
            {AllIngredients.ScalyPholiota, 0},
            {AllIngredients.Taproot, 0},
            {AllIngredients.TorchbugThorax, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}