using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class WeaknessToPoisonIngredientPriority : EffectIngredientPriority<WeaknessToPoisonAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.AbeceanLongfin, 0},
            {AllIngredients.BleedingCrown, 0},
            {AllIngredients.ChaurusEggs, 0},
            {AllIngredients.Deathbell, 0},
            {AllIngredients.GiantLichen, 0},
            {AllIngredients.PineThrushEgg, 0},
            {AllIngredients.SabreCatTooth, 0},
            {AllIngredients.SmallAntlers, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}