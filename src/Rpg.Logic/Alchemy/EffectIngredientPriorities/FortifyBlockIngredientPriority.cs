using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyBlockIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BleedingCrown, 0},
            {AllIngredients.Pearl, 0},
            {AllIngredients.SlaughterfishScales, 0},
            {AllIngredients.TundraCotton, 0},
            {AllIngredients.BriarHeart, -10},
            {AllIngredients.Honeycomb, -10}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}