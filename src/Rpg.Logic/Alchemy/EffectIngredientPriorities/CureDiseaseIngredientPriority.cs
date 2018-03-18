using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class CureDiseaseIngredientPriority : EffectIngredientPriority<CureDiseaseAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.MudcrabChitin, 0},
            {AllIngredients.VampireDust, 0},
            {AllIngredients.CharredSkeeverHide, -10},
            {AllIngredients.HawkFeathers, -10}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}