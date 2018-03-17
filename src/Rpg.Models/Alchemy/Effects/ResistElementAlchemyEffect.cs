using System.Collections.Generic;
using Rpg.Models.Common.Enums;
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
            Name = $"Resist {Effect.Element.ToPresentableString()}";
            Description = $"Resist {Magnitude}% of {Effect.Element.ToPresentableString().ToLowerInvariant()} damage for {Duration} seconds.";
            Id = idMap[Effect.Element];
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        public override string Id { get; }

        private static Dictionary<Element, string> idMap = new Dictionary<Element, string>()
        {
            {Element.Fire, "0003EAEA"},
            {Element.Frost, "0003EAEB"},
            {Element.Shock, "0003EAEC"}
        };
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