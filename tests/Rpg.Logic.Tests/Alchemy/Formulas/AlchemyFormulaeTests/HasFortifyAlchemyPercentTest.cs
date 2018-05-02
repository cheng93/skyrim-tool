using System.Collections.Generic;
using System.Linq;
using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.Formulas.AlchemyFormulaeTests
{
    public class HasFortifyAlchemyPercentTest : Base
    {
        private static IEnumerable<object[]> TestData()
        {
            yield return new object[] {AllAlchemyEffects.DamageMagicka, 82, 82, 0, 27};
            yield return new object[] {AllAlchemyEffects.RegenerateHealth, 277, 277, 300, 45};
            yield return new object[] {AllAlchemyEffects.RestoreStamina, 39, 39, 0, 45};
            yield return new object[] {AllAlchemyEffects.Slow, 386, 386, 45, 50};
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(
            IAlchemyEffect effect,
            decimal baseCost,
            decimal cost,
            decimal duration,
            decimal magnitude)
        {
            Options
                .Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            Options
                .Setup(x => x.AlchemyLevel)
                .Returns(SkillConstants.MaxLevel);

            Options
                .Setup(x => x.FortifyAlchemyPercent)
                .Returns(50);

            TestAndAssert(effect, baseCost, cost, duration, magnitude);
        }
    }
}