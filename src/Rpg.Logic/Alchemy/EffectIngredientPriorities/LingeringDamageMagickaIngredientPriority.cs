using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class LingeringDamageMagickaIngredientPriority : EffectIngredientPriority<LingeringDamageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.HagravenClaw, 0},
            {AllIngredients.PurpleMountainFlower, 0},
            {AllIngredients.SwampFungalPod, 0},
            {AllIngredients.TorchbugThorax, 0},
            {AllIngredients.Wheat, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}