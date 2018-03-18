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

    internal interface IAlchemyFormulae
    {
        AlchemyFormulaeResults GetResults(IAlchemyEffect effect, IAlchemyOptions options);
    }

    internal class AlchemyFormulae : IAlchemyFormulae
    {
        public AlchemyFormulaeResults GetResults(IAlchemyEffect effect, IAlchemyOptions options)
        {
            var baseFactor = BaseFormulae.GetBase(effect, options);
            var perkFactor = PerksFormulae.GetPerks(effect, options.Perks);

            var baseMagnitude = MagnitudeFormulae.GetMagnitude(effect, baseFactor);
            var magnitude = MagnitudeFormulae.GetMagnitude(effect, baseFactor * perkFactor);

            var baseDuration = DurationFormulae.GetDuration(effect, baseFactor);
            var duration = DurationFormulae.GetDuration(effect, baseFactor * perkFactor);

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