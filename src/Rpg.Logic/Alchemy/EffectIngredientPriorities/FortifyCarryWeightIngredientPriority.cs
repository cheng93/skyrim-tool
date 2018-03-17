using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyCarryWeightIngredientPriority : EffectIngredientPriority<FortifyCarryWeightAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.CreepCluster, 0},
            {AllIngredients.GiantsToe, 0},
            {AllIngredients.HawkBeak, 0},
            {AllIngredients.RiverBetty, 0},
            {AllIngredients.ScalyPholiota, 0},
            {AllIngredients.WispWrappings, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}