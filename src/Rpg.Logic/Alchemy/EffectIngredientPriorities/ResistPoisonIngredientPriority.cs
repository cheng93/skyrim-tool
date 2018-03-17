using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class ResistPoisonIngredientPriority : EffectIngredientPriority<ResistPoisonAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.CharredSkeeverHide, 0},
            {AllIngredients.FalmerEar, 0},
            {AllIngredients.Garlic, 0},
            {AllIngredients.GrassPod, 0},
            {AllIngredients.MudcrabChitin, 0},
            {AllIngredients.SlaughterfishEgg, 0},
            {AllIngredients.TrollFat, 0},
            {AllIngredients.BeehiveHusk, -10},
            {AllIngredients.ThistleBranch, -20}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}