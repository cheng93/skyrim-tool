using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Effects;

namespace Rpg.Models.Extensions
{
    public static class AlchemyEffectExtensions
    {
        private static T Scale<T>(
            this T effect,
            double costFactor = 1,
            double durationFactor = 1,
            double magnitudeFactor = 1)
            where T : AlchemyEffect, new()
        {
            return new T()
            {
                Effect = effect.Effect,
                Cost = effect.Cost * costFactor,
                Duration = effect.Duration * durationFactor,
                Magnitude = effect.Magnitude * magnitudeFactor
            };
        }

        internal static T ScaleCost<T>(this T effect, double factor)
            where T : AlchemyEffect, new()
        {
            return effect.Scale<T>(costFactor: factor);
        }

        internal static T ScaleDuration<T>(this T effect, double factor)
            where T : AlchemyEffect, new()
        {
            return effect.Scale<T>(durationFactor: factor);
        }

        internal static T ScaleMagnitude<T>(this T effect, double factor)
            where T : AlchemyEffect, new()
        {
            return effect.Scale<T>(magnitudeFactor: factor);
        }
    }
}