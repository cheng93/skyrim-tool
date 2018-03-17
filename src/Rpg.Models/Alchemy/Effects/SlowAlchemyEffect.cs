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
            IsPositiveEffect = false;
            Name = "Slow";
            Description = $"Target moves at 50% speed for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        public override string Id { get; } = "00073F25";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly SlowAlchemyEffect Slow = new SlowAlchemyEffect(
            AllEffects.Destruction.Slow,
            cost: 1,
            duration: 5,
            magnitude: 50
        );
    }
}