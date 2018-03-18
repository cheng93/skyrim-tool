using Rpg.Models.Effects;
using Rpg.Models.Effects.Destruction;

namespace Rpg.Models.Alchemy.Effects
{
    public class WeaknessToPoisonAlchemyEffect : AlchemyEffect<WeaknessToPoisonEffect>
    {
        public WeaknessToPoisonAlchemyEffect()
        {
        }

        public WeaknessToPoisonAlchemyEffect(
            WeaknessToPoisonEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name { get; } = "Weakness To Poison";

        public override string Id { get; } = "00090042";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly WeaknessToPoisonAlchemyEffect WeaknessToPoison = new WeaknessToPoisonAlchemyEffect(
            AllEffects.Destruction.WeaknessToPoison,
            cost: 1,
            duration: 30,
            magnitude: 2
        );
    }
}