using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal static class BaseFormulae
    {
        public static decimal GetBase(IAlchemyEffect effect, IAlchemyOptions options)
        {
            return AlchemyConstants.IngredientMultiplier
                * (1 + (AlchemyConstants.AlchemySkillFactor - 1) * (decimal)options.AlchemyLevel / 100)
                * (1 + options.FortifyAlchemyPercent / 100);
        }
    }
}