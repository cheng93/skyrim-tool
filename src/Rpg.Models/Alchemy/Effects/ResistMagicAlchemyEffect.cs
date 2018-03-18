using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class ResistMagicAlchemyEffect : AlchemyEffect<ResistMagicEffect>
    {
        public ResistMagicAlchemyEffect(
            ResistMagicEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name { get; } = "Resist Magic";

        public override string Description => $"Resist {Magnitude}% of magic for {Duration} seconds.";

        public override string Id { get; } = "00039E51";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly ResistMagicAlchemyEffect ResistMagic = new ResistMagicAlchemyEffect(
            AllEffects.Restoration.ResistMagic,
            cost: 1,
            duration: 60,
            magnitude: 1
        );
    }
}