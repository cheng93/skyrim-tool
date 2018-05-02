using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class WeaknessToShockIngredientPriority : EffectIngredientPriority<WeaknessToElementAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.Bee, 0},
            {AllIngredients.GiantLichen, 0},
            {AllIngredients.HagravenFeathers, 0},
            {AllIngredients.VoidSalts, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}