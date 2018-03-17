using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class DamageHealthIngredientPriority : EffectIngredientPriority<DamageAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.JarrinRoot, 60},
            {AllIngredients.RiverBetty, 50},
            {AllIngredients.Nirnroot, 40},
            {AllIngredients.CrimsonNirnroot, 30},
            {AllIngredients.Deathbell, 20},
            {AllIngredients.Ectoplasm, 10},
            {AllIngredients.FalmerEar, 10},
            {AllIngredients.HumanFlesh, 10},
            {AllIngredients.HumanHeart, 10},
            {AllIngredients.ImpStool, 10},
            {AllIngredients.Nightshade, 10},
            {AllIngredients.RedMountainFlower, 0},
            {AllIngredients.SkeeverTail, 0},
            {AllIngredients.SmallAntlers, 0},
            {AllIngredients.TrollFat, 0},
            {AllIngredients.VoidSalts, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}