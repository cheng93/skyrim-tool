using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class DamageMagickaIngredientPriority : EffectIngredientPriority<DamageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.ButterflyWing, 0},
            {AllIngredients.ChaurusEggs, 0},
            {AllIngredients.DaedraHeart, 0},
            {AllIngredients.EyeOfSabreCat, 0},
            {AllIngredients.GlowDust, 0},
            {AllIngredients.HagravenFeathers, 0},
            {AllIngredients.HangingMoss, 0},
            {AllIngredients.HumanHeart, 0},
            {AllIngredients.JarrinRoot, 0},
            {AllIngredients.LunaMothWing, 0},
            {AllIngredients.NamirasRot, 0},
            {AllIngredients.NordicBarnacle, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}