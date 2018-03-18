using Rpg.Models.Effects;
using Rpg.Models.Effects.Illusion;

namespace Rpg.Models.Alchemy.Effects
{
    public class FearAlchemyEffect : AlchemyEffect<FearEffect>
    {
        public FearAlchemyEffect(
            FearEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name { get; } = "Fear";

        public override string Description => $"Creatures and people up to level {Magnitude} flee from combat for {Duration} seconds.";

        public override string Id { get; } = "00073F20";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly FearAlchemyEffect Fear = new FearAlchemyEffect(
            AllEffects.Illusion.Fear,
            cost: 5,
            duration: 30,
            magnitude: 1
        );
    }
}