using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyMagickaIngredientPriority : EffectIngredientPriority<FortifyAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BriarHeart, 0},
            {AllIngredients.Ectoplasm, 0},
            {AllIngredients.Histcarp, 0},
            {AllIngredients.JazbayGrapes, 0},
            {AllIngredients.RedMountainFlower, 0},
            {AllIngredients.TundraCotton, 0},
            {AllIngredients.VoidSalts, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}