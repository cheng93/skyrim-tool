using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class DamageMagickaRegenerationIngredientPriority : EffectIngredientPriority<DamageAttributeRegenerationAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BearClaws, 0},
            {AllIngredients.BlueButterflyWing, 0},
            {AllIngredients.BlueMountainFlower, 0},
            {AllIngredients.ChickensEgg, 0},
            {AllIngredients.GlowDust, 0},
            {AllIngredients.HangingMoss, 0},
            {AllIngredients.HumanHeart, 0},
            {AllIngredients.JarrinRoot, 0},
            {AllIngredients.Nightshade, 0},
            {AllIngredients.SpiderEgg, 0},
            {AllIngredients.SprigganSap, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}