using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects.Restoration;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class FortifyAttributeAlchemyEffect : AlchemyEffect<FortifyAttributeEffect>
    {
        public FortifyAttributeAlchemyEffect(
            FortifyAttributeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = $"Fortify {Effect.Attribute.ToPresentableString()}";
            Description = $"{Effect.Attribute.ToPresentableString()} is increased by {Magnitude} points for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}