using System;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal static class CostFormulae
    {
        public static decimal GetCost(IAlchemyEffect effect, decimal magnitude, decimal duration)
        {
            var magnitudeFactor = magnitude > 0
                ? magnitude
                : 1;

            var durationFactor = duration > 0
                ? duration / 10
                : 1;

            return Math.Floor(effect.Cost * (decimal)Math.Pow((double)(magnitudeFactor * durationFactor), 1.1));
        }
    }
}