using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class LingeringDamageStaminaIngredientPriority : EffectIngredientPriority<LingeringDamageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.ButterflyWing, 0},
            {AllIngredients.ChickensEgg, 0},
            {AllIngredients.Nightshade, 0},
            {AllIngredients.SmallAntlers, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}