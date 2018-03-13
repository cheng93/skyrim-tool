using Rpg.Models.Effects.Destruction;

namespace Rpg.Models.Alchemy.Effects
{
    public class WeaknessToPoisonAlchemyEffect : AlchemyEffect<WeaknessToPoisonEffect>
    {
        public WeaknessToPoisonAlchemyEffect(
            WeaknessToPoisonEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = "Weakness To Poison";
            Description = $"Target is {Magnitude}% weaker to poison for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}