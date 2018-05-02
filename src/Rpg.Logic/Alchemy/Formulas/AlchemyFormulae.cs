using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal class AlchemyFormulaeResults
    {
        public AlchemyFormulaeResults(decimal baseCost, decimal cost, decimal duration, decimal magnitude)
        {
            BaseCost = baseCost;
            Cost = cost;
            Duration = duration;
            Magnitude = magnitude;
        }

        public decimal BaseCost { get; }

        public decimal Cost { get; }

        public decimal Duration { get; }

        public decimal Magnitude { get; }
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