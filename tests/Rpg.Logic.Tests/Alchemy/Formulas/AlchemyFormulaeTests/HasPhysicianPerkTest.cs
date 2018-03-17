using System.Collections.Generic;
using System.Linq;
using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.Formulas.AlchemyFormulaeTests
{
    public class HasPhysicianPerkTest : BasePerk
    {
        public HasPhysicianPerkTest()
            : base(AllPerks.Alchemy.Physician)
        {

        }

        private static IEnumerable<object[]> TestData()
        {
            yield return new object[] {AllAlchemyEffects.DamageMagicka, 52, 52, 0, 18};
            yield return new object[] {AllAlchemyEffects.RegenerateHealth, 177, 177, 300, 30};
            yield return new object[] {AllAlchemyEffects.RestoreStamina, 25, 32, 0, 38};
            yield return new object[] {AllAlchemyEffects.Slow, 247, 247, 30, 50};
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
                .Returns(new [] { Perk });

            Options
                .Setup(x => x.AlchemyLevel)
                .Returns(SkillConstants.MaxLevel);

            Options
                .Setup(x => x.FortifyAlchemyPercent)
                .Returns(0);

            TestAndAssert(effect, baseCost, cost, duration, magnitude);
        }
    }
}