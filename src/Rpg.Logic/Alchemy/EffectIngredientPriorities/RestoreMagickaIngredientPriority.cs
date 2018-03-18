using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RestoreMagickaIngredientPriority : EffectIngredientPriority<RestoreAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BriarHeart, 0},
            {AllIngredients.CreepCluster, 0},
            {AllIngredients.DwarvenOil, 0},
            {AllIngredients.Ectoplasm, 0},
            {AllIngredients.ElvesEar, 0},
            {AllIngredients.FireSalts, 0},
            {AllIngredients.FrostSalts, 0},
            {AllIngredients.GiantLichen, 0},
            {AllIngredients.GrassPod, 0},
            {AllIngredients.HumanFlesh, 0},
            {AllIngredients.MoonSugar, 0},
            {AllIngredients.MoraTapinella, 0},
            {AllIngredients.Pearl, 0},
            {AllIngredients.RedMountainFlower, 0},
            {AllIngredients.Taproot, 0},
            {AllIngredients.VampireDust, 0},
            {AllIngredients.WhiteCap, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}