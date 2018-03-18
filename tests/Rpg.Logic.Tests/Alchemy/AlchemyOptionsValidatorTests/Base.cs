using Moq;
using Rpg.Logic.Alchemy;

namespace Rpg.Logic.Tests.Alchemy.AlchemyOptionsValidatorTests
{
    public abstract class Base
    {

        private protected AlchemyOptionsValidator Subject { get; } = new AlchemyOptionsValidator();

        private protected Mock<IAlchemyOptions> AlchemyOptions { get; } = new Mock<IAlchemyOptions>();
    }
}