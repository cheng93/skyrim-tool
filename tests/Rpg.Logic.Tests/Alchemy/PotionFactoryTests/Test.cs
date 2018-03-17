using System;
using FluentAssertions;
using Moq;
using Rpg.Logic.Alchemy;
using Rpg.Models.Alchemy.Ingredients;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.PotionFactoryTests
{
    public class Test
    {
        private readonly PotionFactory subject = new PotionFactory();

        private readonly Mock<IAlchemyOptions> options = new Mock<IAlchemyOptions>();

        [Fact]
        public void NoCommonIngredients()
        {
            var ingredients = new IIngredient[]
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.BearClaws
            };

            options
                .Setup(x => x.Ingredients)
                .Returns(ingredients);

            var potion = subject.Create(options.Object);

            potion.Should().BeNull();
        }

        [Fact]
        public void HasCommonIngredients()
        {
            var ingredients = new IIngredient[]
            {
                AllIngredients.BearClaws,
                AllIngredients.Bee
            };

            options
                .Setup(x => x.Ingredients)
                .Returns(ingredients);

            Action act = () => subject.Create(options.Object);

            act.Should().Throw<System.NotImplementedException>();
        }
    }
}