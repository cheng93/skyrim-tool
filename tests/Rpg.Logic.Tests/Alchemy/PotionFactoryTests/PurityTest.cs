using System.Collections.Generic;
using FluentAssertions;
using Moq;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks.Alchemy;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.PotionFactoryTests
{
    public class PurityTest : BaseIngredientsSamePriority
    {
        private static IEnumerable<object[]> Data()
        {
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.GlowDust,
                    AllIngredients.GlowingMushroom,
                    AllIngredients.HangingMoss,
                },
                $"Poison of {AllAlchemyEffects.DamageMagickaRegeneration.Name}",
                $"{AllAlchemyEffects.DamageMagickaRegeneration.Description} {AllAlchemyEffects.DamageMagicka.Description}",
                256.6
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.ChaurusEggs,
                    AllIngredients.Garlic,
                    AllIngredients.LunaMothWing,
                },
                $"Potion of {AllAlchemyEffects.Invisibility.Name}",
                $"{AllAlchemyEffects.Invisibility.Description} {AllAlchemyEffects.RegenerateHealth.Description} {AllAlchemyEffects.FortifyStamina.Description}",
                622.0
            };
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Test(
            IEnumerable<IIngredient> ingredients,
            string expectedName,
            string expectedDescription,
            decimal cost)
        {
            Options
                .Setup(x => x.Ingredients)
                .Returns(ingredients);

            Options
                .Setup(x => x.Perks)
                .Returns(new[] { new PurityPerk() });

            var potion = Subject.Create(Options.Object);

            potion.Name.Should().Be(expectedName);
            potion.Description.Should().Be(expectedDescription);
            potion.Cost.Should().Be(cost);
        }
    }
}