using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RegenerateMagickaIngredientPriority : EffectIngredientPriority<RegenerateAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.DwarvenOil, 0},
            {AllIngredients.FireSalts, 0},
            {AllIngredients.Garlic, 0},
            {AllIngredients.JazbayGrapes, 0},
            {AllIngredients.MoonSugar, 0},
            {AllIngredients.SaltPile, 0},
            {AllIngredients.Taproot, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}