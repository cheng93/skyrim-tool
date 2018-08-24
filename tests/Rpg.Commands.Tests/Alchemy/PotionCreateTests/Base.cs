using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MediatR;
using Moq;
using Rpg.Commands.Alchemy;
using Rpg.Logic.Alchemy;
using Rpg.Models.Alchemy;
using Rpg.Models.Alchemy.Effects;
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
                .Setup(x => x.FortifyAlchemyPercent(It.IsAny<decimal>()))
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

        protected IRequestHandler<PotionCreate.Command, PotionCreate.Response> Subject;

        protected PotionCreate.Command Request { get; } = new PotionCreate.Command();

        protected Mock<IPotionBuilder> PotionBuilder { get; } = new Mock<IPotionBuilder>();
    }

    public abstract class BaseValid : Base
    {
        protected BaseValid()
        {
            var effect = new Mock<IAlchemyEffect>();
            effect
                .Setup(x => x.Description)
                .Returns(Description);

            var potion = new Mock<IPotion>();
            potion
                .Setup(x => x.Name)
                .Returns(Name);
            potion
                .Setup(x => x.Cost)
                .Returns(Cost);
            potion
                .Setup(x => x.Effects)
                .Returns(new[] { effect.Object });

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

        private readonly decimal Cost = 1.0M;

        protected void TestAndAssert()
        {
            var response = Subject.Handle(Request, It.IsAny<CancellationToken>()).Result;

            response.Potion.Name.Should().Be(Name);
            response.Potion.Cost.Should().Be(Cost);
            response.Potion.Effects.Should().BeEquivalentTo(new[] { Description });
        }
    }
}