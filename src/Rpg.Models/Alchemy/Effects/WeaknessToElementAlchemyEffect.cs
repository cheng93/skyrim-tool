using Rpg.Models.Effects.Destruction;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class WeaknessToElementAlchemyEffect : AlchemyEffect<WeaknessToElementEffect>
    {
        public WeaknessToElementAlchemyEffect(
            WeaknessToElementEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = $"Weakness To {Effect.Element.ToPresentableString()}";
            Description = $"Target is {Magnitude}% weaker to {Effect.Element.ToPresentableString().ToLowerInvariant()} for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}