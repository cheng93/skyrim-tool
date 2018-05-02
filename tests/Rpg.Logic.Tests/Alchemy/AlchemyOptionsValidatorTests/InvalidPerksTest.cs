using FluentAssertions;
using Rpg.Logic.Alchemy;
using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.AlchemyOptionsValidatorTests
{
    public class InvalidPerksTest : Base
    {
        [Fact]
        public void DuplicatePerks()
        {
            AlchemyOptions
                .Setup(x => x.AlchemyLevel)
                .Returns(SkillConstants.MinLevel);

            var perks = new []
            {
                AllPerks.Alchemy.Alchemist.One,
                AllPerks.Alchemy.Alchemist.Two
            };

            AlchemyOptions.Setup(x => x.Perks)
                .Returns(perks);

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin
            };

            AlchemyOptions.Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(AlchemyOptions.Object);
            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
            validationResult.Errors[0].PropertyName.Should().Be(nameof(IAlchemyOptions.Perks));
        }
    }
}