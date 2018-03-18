using System.Collections.Generic;
using FluentAssertions;
using Moq;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.PotionFactoryTests
{
    public class RegularTest : BaseIngredientsSamePriority
    {
        private static IEnumerable<object[]> Data()
        {
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.GlowDust,
                    AllIngredients.HagravenFeathers,
                },
                $"Poison of {AllAlchemyEffects.DamageMagicka.Name}",
                AllAlchemyEffects.DamageMagicka.Description
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.Garlic,
                    AllIngredients.JuniperBerries
                },
                $"Potion of {AllAlchemyEffects.RegenerateHealth.Name}",
                AllAlchemyEffects.RegenerateHealth.Description
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.Bee,
                    AllIngredients.CharredSkeeverHide,
                },
                $"Potion of {AllAlchemyEffects.RestoreStamina.Name}",
                AllAlchemyEffects.RestoreStamina.Description
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.Deathbell,
                    AllIngredients.LargeAntlers,
                },
                $"Poison of {AllAlchemyEffects.Slow.Name}",
                AllAlchemyEffects.Slow.Description
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.GlowDust,
                    AllIngredients.HangingMoss,
                },
                $"Poison of {AllAlchemyEffects.DamageMagickaRegeneration.Name}",
                $"{AllAlchemyEffects.DamageMagickaRegeneration.Description}, {AllAlchemyEffects.DamageMagicka.Description}"
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.GlowDust,
                    AllIngredients.GlowingMushroom,
                    AllIngredients.HangingMoss,
                },
                $"Poison of {AllAlchemyEffects.DamageMagickaRegeneration.Name}",
                $"{AllAlchemyEffects.DamageMagickaRegeneration.Description}, {AllAlchemyEffects.FortifyDestruction.Description}, {AllAlchemyEffects.ResistShock.Description}, {AllAlchemyEffects.FortifyHealth.Description}, {AllAlchemyEffects.DamageMagicka.Description}"
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
                $"{AllAlchemyEffects.Invisibility.Description}, {AllAlchemyEffects.RegenerateHealth.Description}, {AllAlchemyEffects.FortifyStamina.Description}, {AllAlchemyEffects.DamageMagicka.Description}"
            };
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Test(
            IEnumerable<IIngredient> ingredients,
            string expectedName,
            string expectedDescription)
        {
            Options
                .Setup(x => x.Ingredients)
                .Returns(ingredients);

            var potion = Subject.Create(Options.Object);

            potion.Name.Should().Be(expectedName);
            potion.Description.Should().Be(expectedDescription);
        }
    }
}