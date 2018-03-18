using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RegenerateStaminaIngredientPriority : EffectIngredientPriority<RegenerateAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.Bee, 0},
            {AllIngredients.FlyAmanita, 0},
            {AllIngredients.MoraTapinella, 0},
            {AllIngredients.ScalyPholiota, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}