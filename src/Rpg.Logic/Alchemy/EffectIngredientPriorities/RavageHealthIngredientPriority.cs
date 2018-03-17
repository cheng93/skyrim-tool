using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RavageHealthIngredientPriority : EffectIngredientPriority<RavageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.CyrodilicSpadetail, 0},
            {AllIngredients.EyeOfSabreCat, 0},
            {AllIngredients.GiantLichen, 0},
            {AllIngredients.JazbayGrapes, 0},
            {AllIngredients.SilversidePerch, 0},
            {AllIngredients.SkeeverTail, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}