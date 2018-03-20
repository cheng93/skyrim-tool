using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Rpg.Commands.Alchemy;
using Rpg.Logic.Alchemy;
using Rpg.Models.Alchemy;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Commands.Tests.Alchemy.PotionCreateTests
{
    public abstract class Base
    {
        protected Base()
        {
            var potionBuilderFactory = new Mock<IPotionBuilderFactory>();
            potionBuilderFactory
                .Setup(x => x.Create())
                .Returns(PotionBuilder.Object);

            PotionBuilder
                .Setup(x => x.AlchemyLevel(It.IsAny<int>()))
                .Returns(PotionBuilder.Object)
                .Verifiable();

            PotionBuilder
                .Setup(x => x.FortifyAlchemyPercent(It.IsAny<double>()))
                .Returns(PotionBuilder.Object)
                .Verifiable();

            PotionBuilder
                .Setup(x => x.Ingredient(It.IsAny<IIngredient>()))
                .Returns(PotionBuilder.Object)
                .Verifiable();

            PotionBuilder
                .Setup(x => x.Perk(It.IsAny<IPerk<AlchemySkill>>()))
                .Returns(PotionBuilder.Object)
                .Verifiable();

            Subject = new PotionCreate.CommandHandler(potionBuilderFactory.Object);
        }

        protected PotionCreate.CommandHandler Subject;

        protected PotionCreate.Command Request { get; } = new PotionCreate.Command();

        protected Mock<IPotionBuilder> PotionBuilder { get; } = new Mock<IPotionBuilder>();
    }

    public abstract class BaseValid : Base
    {
        protected BaseValid()
        {
            var potion = new Mock<IPotion>();
            potion
                .Setup(x => x.Description)
                .Returns(Description);
            potion
                .Setup(x => x.Name)
                .Returns(Name);

            var validatedPotionBuilder = new Mock<IValidatedPotionBuilder>();
            validatedPotionBuilder
                .Setup(x => x.Build())
                .Returns(potion.Object);

            PotionBuilder
                .Setup(x => x.Validate())
                .Returns(validatedPotionBuilder.Object);
        }

        private readonly string Description = "Description";

        private readonly string Name = "Name";

        protected void TestAndAssert()
        {
            var response = Subject.Handle(Request, It.IsAny<CancellationToken>()).Result;

            response.Potion.Description.Should().Be(Description);
            response.Potion.Name.Should().Be(Name);
        }
    }
}