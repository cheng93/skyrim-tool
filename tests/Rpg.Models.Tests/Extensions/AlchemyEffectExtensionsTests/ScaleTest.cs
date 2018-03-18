using System.Collections.Generic;
using FluentAssertions;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;
using Xunit;

namespace Rpg.Models.Tests.Extensions.AlchemyEffectExtensionsTests
{
    public class Test
    {
        private static IEnumerable<object[]> CostData()
        {
            yield return new object[] {AllAlchemyEffects.DamageMagicka, 4.4};
            yield return new object[] {AllAlchemyEffects.RegenerateHealth, 0.2};
            yield return new object[] {AllAlchemyEffects.RestoreStamina, 1.2};
            yield return new object[] {AllAlchemyEffects.Slow, 2};
        }

        [Theory]
        [MemberData(nameof(CostData))]
        public void Cost(IAlchemyEffect effect, double expected)
        {
            var actual = effect.ScaleCost(2);
            actual.Cost.Should().Be(expected);
        }

        private static IEnumerable<object[]> DurationData()
        {
            yield return new object[] {AllAlchemyEffects.DamageMagicka, 0};
            yield return new object[] {AllAlchemyEffects.RegenerateHealth, 600};
            yield return new object[] {AllAlchemyEffects.RestoreStamina, 0};
            yield return new object[] {AllAlchemyEffects.Slow, 10};
        }

        [Theory]
        [MemberData(nameof(DurationData))]
        public void Duration(IAlchemyEffect effect, double expected)
        {
            var actual = effect.ScaleDuration(2);
            actual.Duration.Should().Be(expected);
        }

        private static IEnumerable<object[]> MagnitudeData()
        {
            yield return new object[] {AllAlchemyEffects.DamageMagicka, 6};
            yield return new object[] {AllAlchemyEffects.RegenerateHealth, 10};
            yield return new object[] {AllAlchemyEffects.RestoreStamina, 10};
            yield return new object[] {AllAlchemyEffects.Slow, 100};
        }

        [Theory]
        [MemberData(nameof(MagnitudeData))]
        public void Magnitude(IAlchemyEffect effect, double expected)
        {
            var actual = effect.ScaleMagnitude(2);
            actual.Magnitude.Should().Be(expected);
        }
    }
}