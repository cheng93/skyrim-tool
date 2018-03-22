using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class ResistPoisonAlchemyEffect : AlchemyEffect<ResistPoisonEffect>
    {
        public ResistPoisonAlchemyEffect(
            ResistPoisonEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name { get; } = "Resist Poison";

        public override string Description => $"Resist {Magnitude}% of poison for {Duration} seconds.";

        public override string Id { get; } = "00090041";
    }

    public static partial class AllAlchemyEffects
    {
        internal static ResistPoisonAlchemyEffect Create(this ResistPoisonAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new ResistPoisonAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly ResistPoisonAlchemyEffect ResistPoison = new ResistPoisonAlchemyEffect(
            AllEffects.Restoration.ResistPoison,
            cost: 0.5M,
            duration: 60,
            magnitude: 4
        );
    }
}