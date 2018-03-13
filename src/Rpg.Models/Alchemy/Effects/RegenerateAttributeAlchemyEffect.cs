using Rpg.Models.Effects.Restoration;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class RegenerateAttributeAlchemyEffect : AlchemyEffect<RegenerateAttributeEffect>
    {
        public RegenerateAttributeAlchemyEffect(
            RegenerateAttributeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = $"Regenerate {Effect.Attribute.ToPresentableString()}";
            Description = $"{Effect.Attribute.ToPresentableString()} regenerates {Magnitude}% faster for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}