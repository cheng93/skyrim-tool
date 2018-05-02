using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class InvisibilityIngredientPriority : EffectIngredientPriority<InvisibilityAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.ChaurusEggs, 0},
            {AllIngredients.CrimsonNirnroot, 0},
            {AllIngredients.IceWraithTeeth, 0},
            {AllIngredients.LunaMothWing, 0},
            {AllIngredients.Nirnroot, 0},
            {AllIngredients.VampireDust, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}