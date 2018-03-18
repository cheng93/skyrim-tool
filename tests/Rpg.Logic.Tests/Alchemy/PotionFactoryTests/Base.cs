using Moq;
using Rpg.Logic.Alchemy;
using Rpg.Logic.Alchemy.EffectIngredientPriorities;
using Rpg.Logic.Alchemy.Formulas;
using Rpg.Logic.Tests.Extensions;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Tests.Alchemy.PotionFactoryTests
{
    public abstract class Base
    {
        protected Base()
        {
            Subject = new PotionFactory(
                EffectIngredientPriorityFactory.Object,
                AlchemyFormulae.Object,
                AlchemyEffectFactory.Object);
        }

        private protected PotionFactory Subject { get; }

        private protected Mock<IEffectIngredientPriorityFactory> EffectIngredientPriorityFactory { get; } = new Mock<IEffectIngredientPriorityFactory>();

        private protected Mock<IAlchemyFormulae> AlchemyFormulae { get; } = new Mock<IAlchemyFormulae>();

        private protected Mock<IAlchemyEffectFactory> AlchemyEffectFactory { get; } = new Mock<IAlchemyEffectFactory>();

        private protected Mock<IAlchemyOptions> Options { get; } = new Mock<IAlchemyOptions>();
    }

    public abstract class BaseHasCommonIngredients : Base
    {
        protected BaseHasCommonIngredients()
        {
            EffectIngredientPriorityFactory
                .Setup(x => x.Create(It.IsAny<IAlchemyEffect>()))
                .Returns(EffectIngredientPriority.Object);

            AlchemyFormulae
                .Setup(x => x.GetResults(
                    It.IsAny<IAlchemyEffect>(),
                    It.IsAny<IAlchemyOptions>()
                ))
                .Returns((IAlchemyEffect effect, IAlchemyOptions options) =>
                    new AlchemyFormulaeResults(
                        effect.Cost.NonZeroOrOne() * effect.Duration.NonZeroOrOne() * effect.Magnitude.NonZeroOrOne(),
                        effect.Cost,
                        effect.Duration,
                        effect.Magnitude));

            AlchemyEffectFactory
                .Setup(x => x.Create(
                    It.IsAny<IAlchemyEffect>(),
                    It.IsAny<double>(),
                    It.IsAny<double>(),
                    It.IsAny<double>()
                ))
                .Returns((
                    IAlchemyEffect effect,
                    double cost, 
                    double duration,
                    double magnitude) => 
                    {
                        var mock = new Mock<IAlchemyEffect>();
                        mock.Setup(x => x.Cost).Returns(cost);
                        mock.Setup(x => x.Description).Returns(effect.Description);
                        mock.Setup(x => x.Duration).Returns(duration);
                        mock.Setup(x => x.Magnitude).Returns(magnitude);
                        return mock.Object;
                    }
                );
        }

        private protected Mock<IEffectIngredientPriority> EffectIngredientPriority { get; } = new Mock<IEffectIngredientPriority>();
    }

    public abstract class BaseIngredientsSamePriority : BaseHasCommonIngredients
    {
        public BaseIngredientsSamePriority()
        {
            EffectIngredientPriority
                .Setup(x => x.GetPriority(It.IsAny<IIngredient>()))
                .Returns(0);
        }
    }
}