using System;
using Rpg.Logic.Extensions;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal static class MagnitudeFormulae
    {
        public static decimal GetMagnitude(IAlchemyEffect effect, decimal powerFactor)
        {
            var magnitudeFactor = effect.PowerAffectsMagnitude()
                ? powerFactor
                : 1;

            return Math.Round(effect.Magnitude * magnitudeFactor, MidpointRounding.AwayFromZero);
        }
    }
}