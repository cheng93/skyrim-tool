using Rpg.Models.Effects;
using Rpg.Models.Effects.Destruction;

namespace Rpg.Models.Alchemy.Effects
{
    public class WeaknessToMagicAlchemyEffect : AlchemyEffect<WeaknessToMagicEffect>
    {
        public WeaknessToMagicAlchemyEffect(
            WeaknessToMagicEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name { get; } = "Weakness To Magic";

        public override string Description => $"Target is {Magnitude}% weaker to magic for {Duration} seconds.";

        public override string Id { get; } = "00073F51";
    }

    public static partial class AllAlchemyEffects
    {
        internal static WeaknessToMagicAlchemyEffect Create(this WeaknessToMagicAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new WeaknessToMagicAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly WeaknessToMagicAlchemyEffect WeaknessToMagic = new WeaknessToMagicAlchemyEffect(
            AllEffects.Destruction.WeaknessToMagic,
            cost: 1,
            duration: 30,
            magnitude: 2
        );
    }
}