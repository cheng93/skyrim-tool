using System;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal static class CostFormulae
    {
        public static double GetCost(IAlchemyEffect effect, double magnitude, double duration)
        {
            var magnitudeFactor = magnitude > 0
                ? magnitude
                : 1;

            var durationFactor = duration > 0
                ? duration / 10
                : 1;

            var additionalFactor = magnitude == 0
                ? 0.0794328
                : 1;
    
            return Math.Floor(effect.Cost * Math.Pow(magnitudeFactor * durationFactor, 1.1) * additionalFactor);
        }
    }
}