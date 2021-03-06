using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Effects;

namespace Rpg.Models.Extensions
{
    public static class AlchemyEffectExtensions
    {
        private static IAlchemyEffect Create(
            this IAlchemyEffect effect,
            decimal costFactor = 1,
            decimal durationFactor = 1,
            decimal magnitudeFactor = 1)
        {
            return new AlchemyEffectFactory()
                .Create(
                    effect,
                    effect.Cost * costFactor,
                    effect.Duration * durationFactor,
                    effect.Magnitude * magnitudeFactor);
        }

        internal static IAlchemyEffect ScaleCost(this IAlchemyEffect effect, decimal factor)
        {
            return Create(effect, costFactor: factor);
        }

        internal static IAlchemyEffect ScaleDuration(this IAlchemyEffect effect, decimal factor)
        {
            return Create(effect, durationFactor: factor);
        }

        internal static IAlchemyEffect ScaleMagnitude(this IAlchemyEffect effect, decimal factor)
        {
            return Create(effect, magnitudeFactor: factor);
        }
    }
}