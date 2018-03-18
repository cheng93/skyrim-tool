using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RavageMagickaIngredientPriority : EffectIngredientPriority<RavageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.FrostMirriam, 0},
            {AllIngredients.GrassPod, 0},
            {AllIngredients.Lavender, 0},
            {AllIngredients.OrangeDartwing, 0},
            {AllIngredients.RedMountainFlower, 0},
            {AllIngredients.WhiteCap, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}