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
    public class InvalidIngredientsTest : Base
    { 
        [Fact]
        public void NotEnoughIngredients()
        {
            AlchemyOptions
                .Setup(x => x.AlchemyLevel)
                .Returns(SkillConstants.MinLevel);

            AlchemyOptions.Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin
            };

            AlchemyOptions.Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(AlchemyOptions.Object);
            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
            validationResult.Errors[0].PropertyName.Should().Be(nameof(IAlchemyOptions.Ingredients));
        }

        [Fact]
        public void TooManyIngredients()
        {
            AlchemyOptions
                .Setup(x => x.AlchemyLevel)
                .Returns(SkillConstants.MinLevel);

            AlchemyOptions.Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin
            };

            AlchemyOptions.Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(AlchemyOptions.Object);
            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
            validationResult.Errors[0].PropertyName.Should().Be(nameof(IAlchemyOptions.Ingredients));
        }
    }
}