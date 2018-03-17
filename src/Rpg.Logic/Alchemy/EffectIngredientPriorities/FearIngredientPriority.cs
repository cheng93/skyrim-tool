using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FearIngredientPriority : EffectIngredientPriority<FearAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BlueDartwing, 0},
            {AllIngredients.CyrodilicSpadetail, 0},
            {AllIngredients.DaedraHeart, 0},
            {AllIngredients.NamirasRot, 0},
            {AllIngredients.PowderedMammothTusk, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}