using System;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal class DurationFormulae
    {
        public static double GetDuration(IAlchemyEffect effect, double powerFactor)
        {
            var durationFactor = effect.PowerAffectsDuration()
                ? powerFactor
                : 1;

            return Math.Round(Math.Max(effect.Duration, 0) * durationFactor);
        }
    }
}