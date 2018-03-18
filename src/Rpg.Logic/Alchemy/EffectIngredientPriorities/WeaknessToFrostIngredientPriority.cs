using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class WeaknessToFrostIngredientPriority : EffectIngredientPriority<WeaknessToElementAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.AbeceanLongfin, 0},
            {AllIngredients.ElvesEar, 0},
            {AllIngredients.FireSalts, 0},
            {AllIngredients.IceWraithTeeth, 0},
            {AllIngredients.WhiteCap, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}