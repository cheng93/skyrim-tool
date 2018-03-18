using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class CureDiseaseAlchemyEffect : AlchemyEffect<CureDiseaseEffect>
    {
        public CureDiseaseAlchemyEffect(
            CureDiseaseEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name { get; } = "Cure Disease";

        public override string Description { get; } = "Cures all diseases.";

        public override string Id { get; } = "000AE722";
    }

    public static partial class AllAlchemyEffects
    {
        internal static CureDiseaseAlchemyEffect Create(this CureDiseaseAlchemyEffect e, double cost, double duration, double magnitude)
        {
            return new CureDiseaseAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly CureDiseaseAlchemyEffect CureDisease = new CureDiseaseAlchemyEffect(
            AllEffects.Restoration.CureDisease,
            cost: 0.5,
            duration: 0,
            magnitude: 5
        );
    }
}