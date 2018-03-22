using Rpg.Models.Effects;
using Rpg.Models.Effects.Illusion;

namespace Rpg.Models.Alchemy.Effects
{
    public class FrenzyAlchemyEffect : AlchemyEffect<FrenzyEffect>
    {
        public FrenzyAlchemyEffect(
            FrenzyEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name { get; } = "Frenzy";

        public override string Description => $"Creatures and people up to level {Magnitude} will attack anything nearby for {Duration} seconds.";

        public override string Id { get; } = "00073F29";
    }

    public static partial class AllAlchemyEffects
    {
        internal static FrenzyAlchemyEffect Create(this FrenzyAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new FrenzyAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly FrenzyAlchemyEffect Frenzy = new FrenzyAlchemyEffect(
            AllEffects.Illusion.Frenzy,
            cost: 15,
            duration: 10,
            magnitude: 1
        );
    }
}