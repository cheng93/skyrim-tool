using Rpg.Models.Effects.Restoration;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class ResistElementAlchemyEffect : AlchemyEffect<ResistElementEffect>
    {
        public ResistElementAlchemyEffect(
            ResistElementEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = $"Resist {effect.Element.ToPresentableString()}";
            Description = $"Resist {Magnitude}% of {effect.Element.ToPresentableString().ToLowerInvariant()} damage for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}