using System;
using FluentAssertions;
using FluentValidation;
using Moq;
using Rpg.Logic.Alchemy;
using Rpg.Models.Alchemy;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.PotionBuilderTests
{
    public class Test
    {
        public Test()
        {
            Subject = new PotionBuilder(potionFactory.Object, validator.Object);
        }

        private readonly PotionBuilder Subject;

        private readonly Mock<IPotionFactory> potionFactory = new Mock<IPotionFactory>();

        private readonly Mock<IAlchemyOptionsValidator> validator = new Mock<IAlchemyOptionsValidator>();

        [Fact]
        public void ValidOptions()
        {
            IAlchemyOptions options = null;
            validator
                .Setup(x => x.ValidateAndThrow(It.IsAny<IAlchemyOptions>()))
                .Callback((IAlchemyOptions o) => {
                    options = o;
                });
                
            potionFactory
                .Setup(x => x.Create(It.IsAny<IAlchemyOptions>()))
                .Returns(It.IsAny<IPotion>())
                .Verifiable();


            var alchemyOptions = It.IsAny<IAlchemyOptions>();

            var potion = Subject.Validate().Build();

            potionFactory.Verify(x => x.Create(options), Times.Once);
        }

        [Fact]
        public void InvalidOptions()
        {
            validator
                .Setup(x => x.ValidateAndThrow(It.IsAny<IAlchemyOptions>()))
                .Throws(new ValidationException(""));

            var alchemyOptions = It.IsAny<IAlchemyOptions>();

            Action action = () => Subject.Validate().Build();

            action.Should().Throw<ValidationException>();
        }
    }
}