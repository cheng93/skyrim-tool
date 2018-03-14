using Rpg.Models.Effects;
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

    public static partial class AllAlchemyEffects
    {
        public static readonly ResistElementAlchemyEffect ResistFire = new ResistElementAlchemyEffect(
            AllEffects.Restoration.ResistFire,
            cost: 0.5,
            duration: 60,
            magnitude: 3
        );

        public static readonly ResistElementAlchemyEffect ResistFrost = new ResistElementAlchemyEffect(
            AllEffects.Restoration.ResistFrost,
            cost: 0.5,
            duration: 60,
            magnitude: 3
        );

        public static readonly ResistElementAlchemyEffect ResistShock = new ResistElementAlchemyEffect(
            AllEffects.Restoration.ResistShock,
            cost: 0.5,
            duration: 60,
            magnitude: 3
        );
    }
}