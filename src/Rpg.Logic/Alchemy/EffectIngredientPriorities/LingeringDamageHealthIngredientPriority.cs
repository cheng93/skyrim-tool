using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class LingeringDamageHealthIngredientPriority : EffectIngredientPriority<LingeringDamageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.ImpStool, 0},
            {AllIngredients.MoraTapinella, 0},
            {AllIngredients.OrangeDartwing, 0},
            {AllIngredients.SlaughterfishEgg, 0},
            {AllIngredients.SlaughterfishScales, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}