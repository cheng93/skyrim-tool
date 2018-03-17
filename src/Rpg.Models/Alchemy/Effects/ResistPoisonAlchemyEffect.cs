using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class ResistPoisonAlchemyEffect : AlchemyEffect<ResistPoisonEffect>
    {
        public ResistPoisonAlchemyEffect()
        {
        }

        public ResistPoisonAlchemyEffect(
            ResistPoisonEffect effect,
            double cost,
            double duration,
            double magnitude)
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
        public static readonly ResistPoisonAlchemyEffect ResistPoison = new ResistPoisonAlchemyEffect(
            AllEffects.Restoration.ResistPoison,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );
    }
}