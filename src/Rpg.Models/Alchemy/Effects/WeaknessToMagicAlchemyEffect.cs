using Rpg.Models.Effects;
using Rpg.Models.Effects.Destruction;

namespace Rpg.Models.Alchemy.Effects
{
    public class WeaknessToMagicAlchemyEffect : AlchemyEffect<WeaknessToMagicEffect>
    {
        public WeaknessToMagicAlchemyEffect(
            WeaknessToMagicEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = "Weakness To Magic";
            Description = $"Target is {Magnitude}% weaker to magic for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        public override string Id { get; } = "00073F51";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly WeaknessToMagicAlchemyEffect WeaknessToMagic = new WeaknessToMagicAlchemyEffect(
            AllEffects.Destruction.WeaknessToMagic,
            cost: 1,
            duration: 30,
            magnitude: 2
        );
    }
}