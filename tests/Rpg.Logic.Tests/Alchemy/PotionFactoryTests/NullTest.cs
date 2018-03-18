using FluentAssertions;
using Rpg.Models.Alchemy.Ingredients;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.PotionFactoryTests
{
    public class NullTest : Base
    {
        [Fact]
        public void NoCommonEffects()
        {
            var ingredients = new IIngredient[]
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.BearClaws
            };

            Options
                .Setup(x => x.Ingredients)
                .Returns(ingredients);

            var potion = Subject.Create(Options.Object);

            potion.Should().BeNull();
        }
    }
}