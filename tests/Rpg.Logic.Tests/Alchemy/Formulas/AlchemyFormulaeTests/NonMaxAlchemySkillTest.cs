using System.Collections.Generic;
using System.Linq;
using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.Formulas.AlchemyFormulaeTests
{
    public class NonMaxAlchemySkillTest : Base
    {
        private static IEnumerable<object[]> TestData()
        {
            yield return new object[] {AllAlchemyEffects.DamageMagicka, 46, 46, 0, 16};
            yield return new object[] {AllAlchemyEffects.RegenerateHealth, 151, 151, 300, 26};
            yield return new object[] {AllAlchemyEffects.RestoreStamina, 21, 21, 0, 26};
            yield return new object[] {AllAlchemyEffects.Slow, 211, 211, 26, 50};
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(
            IAlchemyEffect effect,
            double baseCost,
            double cost,
            double duration,
            double magnitude)
        {
            Options
                .Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            Options
                .Setup(x => x.AlchemyLevel)
                .Returns(60);

            Options
                .Setup(x => x.FortifyAlchemyPercent)
                .Returns(0);

            TestAndAssert(effect, baseCost, cost, duration, magnitude);
        }
    }
}