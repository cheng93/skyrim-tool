using FluentAssertions;
using Moq;
using Rpg.Logic.Alchemy;
using Rpg.Logic.Alchemy.Formulas;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Tests.Alchemy.Formulas.AlchemyFormulaeTests
{
    public abstract class Base
    {
        private protected AlchemyFormulae Subject = new AlchemyFormulae();

        private protected Mock<IAlchemyOptions> Options { get; } = new Mock<IAlchemyOptions>();

        protected void TestAndAssert(
            IAlchemyEffect effect,
            double baseCost,
            double cost,
            double duration,
            double magnitude)
        {
            var results = Subject.GetResults(effect, Options.Object);
            results.BaseCost.Should().Be(baseCost);
            results.Cost.Should().Be(cost);
            results.Duration.Should().Be(duration);
            results.Magnitude.Should().Be(magnitude);
        }
    }

    public abstract class BasePerk : Base
    {
        protected BasePerk(IPerk<AlchemySkill> perk)
        {
            Perk = perk;
        }

        private protected IPerk<AlchemySkill> Perk { get; }
    }
}