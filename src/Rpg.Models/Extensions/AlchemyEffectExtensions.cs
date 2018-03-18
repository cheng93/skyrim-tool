using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Effects;

namespace Rpg.Models.Extensions
{
    public static class AlchemyEffectExtensions
    {
        public static AlchemyEffect<T> ScaleCost<T>(this AlchemyEffect<T> effect, double factor)
            where T : class, IEffect
        {
            return new ScalingAlchemyEffect<T>(effect, costFactor: factor);
        }

        public static AlchemyEffect<T> ScaleDuration<T>(this AlchemyEffect<T> effect, double factor)
            where T : class, IEffect
        {
            return new ScalingAlchemyEffect<T>(effect, durationFactor: factor);
        }

        public static AlchemyEffect<T> ScaleMagnitude<T>(this AlchemyEffect<T> effect, double factor)
            where T : class, IEffect
        {
            return new ScalingAlchemyEffect<T>(effect, magnitudeFactor: factor);
        }
    }
}