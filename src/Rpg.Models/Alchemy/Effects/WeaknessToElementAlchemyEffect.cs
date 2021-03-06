using System.Collections.Generic;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class WeaknessToElementAlchemyEffect : AlchemyEffect<WeaknessToElementEffect>
    {
        public WeaknessToElementAlchemyEffect(
            WeaknessToElementEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name => $"Weakness To {Effect.Element.ToPresentableString()}";

        public override string Description => $"Target is {Magnitude}% weaker to {Effect.Element.ToPresentableString().ToLowerInvariant()} for {Duration} seconds.";

        public override string Id => idMap[Effect.Element];

        private static Dictionary<Element, string> idMap = new Dictionary<Element, string>()
        {
            {Element.Fire, "00073F2D"},
            {Element.Frost, "00073F2E"},
            {Element.Shock, "00073F2F"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        internal static WeaknessToElementAlchemyEffect Create(this WeaknessToElementAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new WeaknessToElementAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly WeaknessToElementAlchemyEffect WeaknessToFire = new WeaknessToElementAlchemyEffect(
            AllEffects.Destruction.WeaknessToFire,
            cost: 0.6M,
            duration: 30,
            magnitude: 3
        );

        public static readonly WeaknessToElementAlchemyEffect WeaknessToFrost = new WeaknessToElementAlchemyEffect(
            AllEffects.Destruction.WeaknessToFrost,
            cost: 0.5M,
            duration: 30,
            magnitude: 3
        );

        public static readonly WeaknessToElementAlchemyEffect WeaknessToShock = new WeaknessToElementAlchemyEffect(
            AllEffects.Destruction.WeaknessToShock,
            cost: 0.7M,
            duration: 30,
            magnitude: 3
        );
    }
}