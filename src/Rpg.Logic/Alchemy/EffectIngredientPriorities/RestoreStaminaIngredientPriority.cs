using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RestoreStaminaIngredientPriority : EffectIngredientPriority<RestoreAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.Bee, 0},
            {AllIngredients.CharredSkeeverHide, 0},
            {AllIngredients.EyeOfSabreCat, 0},
            {AllIngredients.HawkBeak, 0},
            {AllIngredients.Histcarp, 0},
            {AllIngredients.Honeycomb, 0},
            {AllIngredients.LargeAntlers, 0},
            {AllIngredients.MudcrabChitin, 0},
            {AllIngredients.OrangeDartwing, 0},
            {AllIngredients.Pearl, 0},
            {AllIngredients.PineThrushEgg, 0},
            {AllIngredients.PowderedMammothTusk, 0},
            {AllIngredients.PurpleMountainFlower, 0},
            {AllIngredients.SabreCatTooth, 0},
            {AllIngredients.SilversidePerch, 0},
            {AllIngredients.SmallPearl, 0},
            {AllIngredients.TorchbugThorax, 0},
            {AllIngredients.WispWrappings, 0},
            {AllIngredients.BearClaws, -10}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}