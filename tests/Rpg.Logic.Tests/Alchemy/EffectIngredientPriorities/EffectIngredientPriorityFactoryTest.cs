using System.Collections.Generic;
using FluentAssertions;
using Rpg.Logic.Alchemy.EffectIngredientPriorities;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.EffectIngredientPriorities
{
    public class EffectIngredientPriorityFactoryTest
    {
        private readonly EffectIngredientPriorityFactory Subject = new EffectIngredientPriorityFactory();

        private static IEnumerable<object[]> TestData()
        {
            yield return new object[] { AllAlchemyEffects.DamageHealth };
            yield return new object[] { AllIngredients.Nirnroot.PrimaryEffect };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void SameEffect(IAlchemyEffect effect)
        {
            var result = Subject.Create(effect);

            result.Should().BeOfType(typeof(DamageHealthIngredientPriority));
        }
    }
}