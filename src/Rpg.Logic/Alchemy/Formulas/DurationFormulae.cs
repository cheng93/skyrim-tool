using System;
using Rpg.Logic.Extensions;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal class DurationFormulae
    {
        public static decimal GetDuration(IAlchemyEffect effect, decimal powerFactor)
        {
            var durationFactor = effect.PowerAffectsDuration()
                ? powerFactor
                : 1;

            return Math.Round(Math.Max(effect.Duration, 0) * durationFactor, MidpointRounding.AwayFromZero);
        }
    }
}