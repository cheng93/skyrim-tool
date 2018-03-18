using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal static class BaseFormulae
    {
        public static double GetBase(IAlchemyEffect effect, IAlchemyOptions options)
        {
            return AlchemyConstants.IngredientMultiplier
                * (1 + (AlchemyConstants.AlchemySkillFactor - 1) * (double)options.AlchemyLevel / 100)
                * (1 + options.FortifyAlchemyPercent / 100);
        }
    }
}