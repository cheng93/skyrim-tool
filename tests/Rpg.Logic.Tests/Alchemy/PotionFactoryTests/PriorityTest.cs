using System.Collections.Generic;
using FluentAssertions;
using Moq;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.PotionFactoryTests
{
    public class PriorityTest : BaseHasCommonIngredients
    {
        public PriorityTest()
        {
            EffectIngredientPriority
                .Setup(x => x.GetPriority(It.IsAny<IIngredient>()))
                .Returns((IIngredient ingredient) => {
                    if (ingredient == AllIngredients.RiverBetty)
                    {
                        return 20;
                    }
                    else if (ingredient == AllIngredients.Nirnroot)
                    {
                        return 10;
                    }
                    else 
                    {
                        return 0;
                    }
                });
        }

        private static IEnumerable<object[]> Data()
        {
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.Ectoplasm,
                    AllIngredients.Nirnroot,
                    AllIngredients.RiverBetty
                },
                $"Poison of {AllAlchemyEffects.DamageHealth.Name}",
                AllIngredients.RiverBetty.PrimaryEffect.Description,
                15.0
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.Ectoplasm,
                    AllIngredients.RiverBetty
                },
                $"Poison of {AllAlchemyEffects.DamageHealth.Name}",
                AllIngredients.RiverBetty.PrimaryEffect.Description,
                15.0
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.Nirnroot,
                    AllIngredients.RiverBetty
                },
                $"Poison of {AllAlchemyEffects.DamageHealth.Name}",
                AllIngredients.RiverBetty.PrimaryEffect.Description,
                15.0
            };
            yield return new object []
            {
                new IIngredient[]
                {
                    AllIngredients.Ectoplasm,
                    AllIngredients.Nirnroot
                },
                $"Poison of {AllAlchemyEffects.DamageHealth.Name}",
                AllIngredients.Nirnroot.PrimaryEffect.Description,
                75.6
            };
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Test(
            IEnumerable<IIngredient> ingredients,
            string expectedName,
            string expectedDescription,
            double cost)
        {
            Options
                .Setup(x => x.Ingredients)
                .Returns(ingredients);

            var potion = Subject.Create(Options.Object);

            potion.Name.Should().Be(expectedName);
            potion.Description.Should().Be(expectedDescription);
            potion.Cost.Should().Be(cost);
        }        
    }
}