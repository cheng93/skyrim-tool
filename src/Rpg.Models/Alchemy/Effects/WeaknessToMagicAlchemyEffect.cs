using Rpg.Models.Effects;
using Rpg.Models.Effects.Destruction;

namespace Rpg.Models.Alchemy.Effects
{
    public class WeaknessToMagicAlchemyEffect : AlchemyEffect<WeaknessToMagicEffect>
    {
        public WeaknessToMagicAlchemyEffect()
        {
        }

        public WeaknessToMagicAlchemyEffect(
            WeaknessToMagicEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name { get; } = "Weakness To Magic";

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