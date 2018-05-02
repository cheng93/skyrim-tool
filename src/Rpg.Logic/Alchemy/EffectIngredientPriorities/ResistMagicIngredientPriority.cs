using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class ResistMagicIngredientPriority : EffectIngredientPriority<ResistMagicAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BleedingCrown, 0},
            {AllIngredients.ChickensEgg, 0},
            {AllIngredients.CrimsonNirnroot, 0},
            {AllIngredients.HagravenClaw, 0},
            {AllIngredients.Lavender, 0},
            {AllIngredients.Nirnroot, 0},
            {AllIngredients.TundraCotton, 0},
            {AllIngredients.VoidSalts, 0},
            {AllIngredients.WispWrappings, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}