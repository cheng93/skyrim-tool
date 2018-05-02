using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class SlowIngredientPriority : EffectIngredientPriority<SlowAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.Deathbell, 0},
            {AllIngredients.LargeAntlers, 0},
            {AllIngredients.RiverBetty, 0},
            {AllIngredients.SaltPile, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}