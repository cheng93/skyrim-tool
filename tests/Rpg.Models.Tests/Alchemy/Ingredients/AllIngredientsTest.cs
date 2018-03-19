using System.Linq;
using FluentAssertions;
using Rpg.Models.Alchemy.Ingredients;
using Xunit;

namespace Rpg.Models.Tests.Alchemy.Ingredients
{
    public class AllIngredientsTest
    {
        [Fact]
        public void UniqueIds()
        {
            var ingredients = AllIngredients.List;

            var duplicateIds = ingredients
                .GroupBy(x => x.Id)
                .Where(x => x.Count() > 1);

            duplicateIds.Should().BeEmpty();
        }

        [Fact]
        public void IdsNotNullOrWhitespace()
        {
            var ingredients = AllIngredients.List;

            var count = ingredients.Count(x => string.IsNullOrWhiteSpace(x.Id));

            count.Should().Be(0);
        }
    }
}