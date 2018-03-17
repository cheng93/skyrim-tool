using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal class AlchemyFormulaeResults
    {
        public AlchemyFormulaeResults(double baseCost, double cost, double duration, double magnitude)
        {
            BaseCost = baseCost;
            Cost = cost;
            Duration = duration;
            Magnitude = magnitude;
        }

        public double BaseCost { get; }

        public double Cost { get; }

        public double Duration { get; }

        public double Magnitude { get; }
    }

    internal static class AlchemyFormulae
    {
        public static AlchemyFormulaeResults GetResults(IAlchemyEffect effect, IAlchemyOptions options)
        {
            var baseFactor = BaseFormulae.GetBase(effect, options);
            var perkFactor = PerksFormulae.GetPerks(effect, options.Perks);

            var baseMagnitude = MagnitudeFormulae.GetMagnitude(effect, baseFactor);
            var magnitude = baseMagnitude * perkFactor;

            var baseDuration = DurationFormulae.GetDuration(effect, baseFactor);
            var duration = baseDuration * perkFactor;

            var baseCost = CostFormulae.GetCost(effect, baseMagnitude, baseDuration);
            var cost = CostFormulae.GetCost(effect, magnitude, duration);

            return new AlchemyFormulaeResults(
                baseCost,
                cost,
                duration,
                magnitude);
        }
    }
}