using System.Linq;
using FluentAssertions;
using Rpg.Logic.Alchemy;
using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.AlchemyOptionsValidatorTests
{
    public class InvalidAlchemyLevelTest : Base
    {
        [Fact]
        public void AlchemyLevelTooLow()
        {
            AlchemyOptions
                .Setup(x => x.AlchemyLevel)
                .Returns(SkillConstants.MinLevel -1);

            AlchemyOptions
                .Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin
            };

            AlchemyOptions
                .Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(AlchemyOptions.Object);
            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
            validationResult.Errors[0].PropertyName.Should().Be(nameof(IAlchemyOptions.AlchemyLevel));
        }

        [Fact]
        public void AlchemyLevelTooHigh()
        {
            AlchemyOptions
                .Setup(x => x.AlchemyLevel)
                .Returns(SkillConstants.MaxLevel +1);

            AlchemyOptions
                .Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin
            };

            AlchemyOptions
                .Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(AlchemyOptions.Object);
            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
            validationResult.Errors[0].PropertyName.Should().Be(nameof(IAlchemyOptions.AlchemyLevel));
        }
    }
}