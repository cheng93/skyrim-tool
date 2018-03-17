using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Effects;

namespace Rpg.Models.Extensions
{
    public static class AlchemyEffectExtensions
    {
        public static AlchemyEffect<T> ScaleCost<T>(this AlchemyEffect<T> effect, double factor)
            where T : Effect<T>
        {
            return new ScalingAlchemyEffect<T>(effect, costFactor: factor);
        }

        public static AlchemyEffect<T> ScaleDuration<T>(this AlchemyEffect<T> effect, double factor)
            where T : Effect<T>
        {
            return new ScalingAlchemyEffect<T>(effect, durationFactor: factor);
        }

        public static AlchemyEffect<T> ScaleMagnitude<T>(this AlchemyEffect<T> effect, double factor)
            where T : Effect<T>
        {
            return new ScalingAlchemyEffect<T>(effect, magnitudeFactor: factor);
        }

        public static TAlchemyEffect Create<TAlchemyEffect, TEffect>(this TAlchemyEffect e, double cost, double duration, double magnitude)
            where TAlchemyEffect: AlchemyEffect<TEffect>, new()
            where TEffect : IEffect<TEffect>
        {
            return new TAlchemyEffect()
            {
                Effect = e.Effect,
                Cost = cost,
                Duration = duration,
                Magnitude = magnitude
            };
        }
    }
}