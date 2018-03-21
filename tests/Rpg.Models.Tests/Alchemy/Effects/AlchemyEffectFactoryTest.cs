using System.Collections.Generic;
using FluentAssertions;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;
using Xunit;

namespace Rpg.Models.Tests.Alchemy.Effects
{
    public class AlchemyEffectFactoryTest
    {
        private readonly AlchemyEffectFactory Subject = new AlchemyEffectFactory();

        private static IEnumerable<object[]> TestData()
        {
            yield return new object[] { AllAlchemyEffects.CureDisease };
            yield return new object[] { AllAlchemyEffects.CureDisease.ScaleCost(1) };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void SameEffect(IAlchemyEffect effect)
        {
            var result = Subject.Create(effect, 1, 1, 1);

            result.Should().BeOfType(AllAlchemyEffects.CureDisease.GetType());
            result.Cost.Should().Be(1);
            result.Duration.Should().Be(1);
            result.Magnitude.Should().Be(1);
        }
    }
}