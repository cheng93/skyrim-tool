using System.Collections.Generic;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class WeaknessToElementAlchemyEffect : AlchemyEffect<WeaknessToElementEffect>
    {
        public WeaknessToElementAlchemyEffect()
        {
        }

        public WeaknessToElementAlchemyEffect(
            WeaknessToElementEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name => $"Weakness To {Effect.Element.ToPresentableString()}";

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
        public static readonly WeaknessToElementAlchemyEffect WeaknessToFire = new WeaknessToElementAlchemyEffect(
            AllEffects.Destruction.WeaknessToFire,
            cost: 0.6,
            duration: 30,
            magnitude: 3
        );

        public static readonly WeaknessToElementAlchemyEffect WeaknessToFrost = new WeaknessToElementAlchemyEffect(
            AllEffects.Destruction.WeaknessToFrost,
            cost: 0.5,
            duration: 30,
            magnitude: 3
        );

        public static readonly WeaknessToElementAlchemyEffect WeaknessToShock = new WeaknessToElementAlchemyEffect(
            AllEffects.Destruction.WeaknessToShock,
            cost: 0.7,
            duration: 30,
            magnitude: 3
        );
    }
}