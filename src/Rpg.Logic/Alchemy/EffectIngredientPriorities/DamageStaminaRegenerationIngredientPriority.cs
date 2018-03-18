using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class DamageStaminaRegenerationIngredientPriority : EffectIngredientPriority<DamageAttributeRegenerationAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.CreepCluster, 0},
            {AllIngredients.DaedraHeart, 0},
            {AllIngredients.FrostMirriam, 0},
            {AllIngredients.GiantsToe, 0},
            {AllIngredients.Histcarp, 0},
            {AllIngredients.JuniperBerries, 0},
            {AllIngredients.LargeAntlers, 0},
            {AllIngredients.SilversidePerch, 0},
            {AllIngredients.SkeeverTail, 0},
            {AllIngredients.Wheat, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}