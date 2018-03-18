using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class DamageStaminaIngredientPriority : EffectIngredientPriority<DamageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.CrimsonNirnroot, 10},
            {AllIngredients.BeritsAshes, 0},
            {AllIngredients.Blisterwort, 0},
            {AllIngredients.BlueButterflyWing, 0},
            {AllIngredients.BoneMeal, 0},
            {AllIngredients.CanisRoot, 0},
            {AllIngredients.CyrodilicSpadetail, 0},
            {AllIngredients.GiantsToe, 0},
            {AllIngredients.JarrinRoot, 0},
            {AllIngredients.Nirnroot, 0},
            {AllIngredients.RockWarblerEgg, 0},
            {AllIngredients.SpiderEgg, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}