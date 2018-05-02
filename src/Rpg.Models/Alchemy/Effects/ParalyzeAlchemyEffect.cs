using Rpg.Models.Effects;
using Rpg.Models.Effects.Alteration;

namespace Rpg.Models.Alchemy.Effects
{
    public class ParalyzeAlchemyEffect : AlchemyEffect<ParalyzeEffect>
    {
        public ParalyzeAlchemyEffect(
            ParalyzeEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name { get; } = "Paralysis";

        public override string Description => $"Target is paralyzed for {Duration} seconds.";

        public override string Id { get; } = "00073F30";
    }

    public static partial class AllAlchemyEffects
    {
        internal static ParalyzeAlchemyEffect Create(this ParalyzeAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new ParalyzeAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly ParalyzeAlchemyEffect Paralyze = new ParalyzeAlchemyEffect(
            AllEffects.Alteration.Paralyze,
            cost: 500,
            duration: 1,
            magnitude: 0
        );
    }
}