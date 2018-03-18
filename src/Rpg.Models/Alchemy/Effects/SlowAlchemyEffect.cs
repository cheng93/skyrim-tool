using Rpg.Models.Effects;
using Rpg.Models.Effects.Destruction;

namespace Rpg.Models.Alchemy.Effects
{
    public class SlowAlchemyEffect : AlchemyEffect<SlowEffect>
    {
        public SlowAlchemyEffect(
            SlowEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name { get; } = "Slow";

        public override string Description => $"Target moves at 50% speed for {Duration} seconds.";

        public override string Id { get; } = "00073F25";
    }

    public static partial class AllAlchemyEffects
    {
        internal static SlowAlchemyEffect Create(this SlowAlchemyEffect e, double cost, double duration, double magnitude)
        {
            return new SlowAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly SlowAlchemyEffect Slow = new SlowAlchemyEffect(
            AllEffects.Destruction.Slow,
            cost: 1,
            duration: 5,
            magnitude: 50
        );
    }
}