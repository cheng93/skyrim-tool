using System.Collections.Generic;
using System.Linq;
using Moq;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks.Alchemy;
using Xunit;

namespace Rpg.Commands.Tests.Alchemy.PotionCreateTests
{
    public class ValidPotionTest : BaseValid
    {
        [Theory]
        [InlineData(0)]
        [InlineData(25)]
        [InlineData(50)]
        [InlineData(75)]
        [InlineData(100)]
        public void VariousAlchemyLevel(int alchemyLevel)
        {
            Request.AlchemyLevel = alchemyLevel;
            TestAndAssert();

            PotionBuilder.Verify(x => x.AlchemyLevel(alchemyLevel), Times.Once);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(25)]
        [InlineData(50)]
        [InlineData(75)]
        [InlineData(100)]
        [InlineData(150)]
        [InlineData(60.5)]
        public void VariousFortifyAlchemyPercent(double fortifyAlchemyPercent)
        {
            Request.FortifyAlchemyPercent = fortifyAlchemyPercent;
            TestAndAssert();

            PotionBuilder.Verify(x => x.FortifyAlchemyPercent(fortifyAlchemyPercent), Times.Once);
        }

        [Fact]
        public void HasBenefactorPerk()
        {
            Request.HasBenefactorPerk = true;
            TestAndAssert();

            PotionBuilder.Verify(x => x.Perk(It.IsAny<BenefactorPerk>()), Times.Once);
        }

        [Fact]
        public void HasPhysicianPerk()
        {
            Request.HasPhysicianPerk = true;
            TestAndAssert();

            PotionBuilder.Verify(x => x.Perk(It.IsAny<PhysicianPerk>()), Times.Once);
        }

        [Fact]
        public void HasPoisonerPerk()
        {
            Request.HasPoisonerPerk = true;
            TestAndAssert();

            PotionBuilder.Verify(x => x.Perk(It.IsAny<PoisonerPerk>()), Times.Once);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void HasValidAlchemistPerk(int alchemistRank)
        {
            Request.AlchemistPerkRank = alchemistRank;
            TestAndAssert();

            PotionBuilder.Verify(x => x.Perk(It.Is<AlchemistPerk>(y => y.Rank == alchemistRank)), Times.Once);
        }

        [Fact]
        public void HasInvalidAlchemistPerk()
        {
            Request.AlchemistPerkRank = 0;
            TestAndAssert();

            PotionBuilder.Verify(x => x.Perk(It.IsAny<AlchemistPerk>()), Times.Never);
        }

        private static IEnumerable<object[]> IngredientIdList()
        {
            yield return new object[]
            {
                new [] {
                    AllIngredients.AbeceanLongfin.Id
                }
            };
            yield return new object[]
            {
                new [] {
                    AllIngredients.AbeceanLongfin.Id,
                    AllIngredients.BearClaws.Id
                }
            };
            yield return new object[]
            {
                new [] {
                    AllIngredients.AbeceanLongfin.Id,
                    AllIngredients.BearClaws.Id,
                    AllIngredients.CharredSkeeverHide.Id
                }
            };
        }

        [Theory]
        [MemberData(nameof(IngredientIdList))]
        public void Ingredients(IEnumerable<string> ingredientIds)
        {
            Request.IngredientIds = ingredientIds;
            TestAndAssert();

            foreach (var id in ingredientIds)
            {
                PotionBuilder.Verify(x => x.Ingredient(It.Is<IIngredient>(y => y.Id == id)), Times.Once);
            }
        }
    }
}