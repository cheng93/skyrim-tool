using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyStaminaIngredientPriority : EffectIngredientPriority<FortifyAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.ChaurusEggs, 0},
            {AllIngredients.Garlic, 0},
            {AllIngredients.LargeAntlers, 0},
            {AllIngredients.Lavender, 0},
            {AllIngredients.SlaughterfishEgg, 0},
            {AllIngredients.TorchbugThorax, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}