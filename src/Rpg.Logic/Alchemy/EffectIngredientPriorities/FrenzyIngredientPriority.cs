using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FrenzyIngredientPriority : EffectIngredientPriority<FrenzyAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.Blisterwort, 0},
            {AllIngredients.FalmerEar, 0},
            {AllIngredients.FlyAmanita, 0},
            {AllIngredients.HagravenFeathers, 0},
            {AllIngredients.HumanHeart, 0},
            {AllIngredients.TrollFat, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}