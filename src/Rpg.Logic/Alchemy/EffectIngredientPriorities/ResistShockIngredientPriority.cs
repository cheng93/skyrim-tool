using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class ResistShockIngredientPriority : EffectIngredientPriority<ResistElementAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BlueDartwing, 0},
            {AllIngredients.GlowDust, 0},
            {AllIngredients.GlowingMushroom, 0},
            {AllIngredients.HawkBeak, 0},
            {AllIngredients.Pearl, 0},
            {AllIngredients.PineThrushEgg, 0},
            {AllIngredients.Snowberries, 0},
            {AllIngredients.SwampFungalPod, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}