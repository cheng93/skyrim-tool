using System.Linq;
using FluentAssertions;
using Moq;
using Rpg.Logic.Alchemy;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.AlchemyOptionsValidatorTests
{
    public class Test
    {
        public AlchemyOptionsValidator Subject = new AlchemyOptionsValidator();

        private Mock<IAlchemyOptions> alchemyOptions = new Mock<IAlchemyOptions>();

        [Fact]
        public void ValidOptions()
        {
            alchemyOptions.Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin
            };

            alchemyOptions.Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(alchemyOptions.Object);
            validationResult.IsValid.Should().BeTrue();
        }

        [Fact]
        public void NotEnoughIngredients()
        {
            alchemyOptions.Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin
            };

            alchemyOptions.Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(alchemyOptions.Object);
            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
            validationResult.Errors[0].PropertyName.Should().Be(nameof(IAlchemyOptions.Ingredients));
        }

        [Fact]
        public void TooManyIngredients()
        {
            alchemyOptions.Setup(x => x.Perks)
                .Returns(Enumerable.Empty<IPerk<AlchemySkill>>());

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin
            };

            alchemyOptions.Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(alchemyOptions.Object);
            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
            validationResult.Errors[0].PropertyName.Should().Be(nameof(IAlchemyOptions.Ingredients));
        }

        [Fact]
        public void DuplicatePerks()
        {
            var perks = new []
            {
                AllPerks.Alchemy.Alchemist.One,
                AllPerks.Alchemy.Alchemist.Two
            };

            alchemyOptions.Setup(x => x.Perks)
                .Returns(perks);

            var ingredients = new []
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.AbeceanLongfin
            };

            alchemyOptions.Setup(x => x.Ingredients)
                .Returns(ingredients);

            var validationResult = Subject.Validate(alchemyOptions.Object);
            validationResult.IsValid.Should().BeFalse();
            validationResult.Errors.Count.Should().Be(1);
            validationResult.Errors[0].PropertyName.Should().Be(nameof(IAlchemyOptions.Perks));
        }
    }
}