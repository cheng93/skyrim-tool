using Rpg.Models.Effects;

namespace Rpg.Models.Alchemy.Effects
{
    public class ScalingAlchemyEffect<T> : AlchemyEffect<T>
        where T : class, IEffect
    {
        public ScalingAlchemyEffect(
            AlchemyEffect<T> alchemyEffect,
            double costFactor = 1,
            double durationFactor = 1,
            double magnitudeFactor = 1)
            : base(
                alchemyEffect.Effect,
                alchemyEffect.Cost * costFactor,
                alchemyEffect.Duration * durationFactor,
                alchemyEffect.Magnitude * magnitudeFactor)
        {
            IsPositiveEffect = alchemyEffect.IsPositiveEffect;
            Name = alchemyEffect.Name;
            Id = alchemyEffect.Id;
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Id { get; }
    }
}