using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using FluentValidation;
using Moq;
using Xunit;

namespace Rpg.Commands.Tests.Alchemy.PotionCreateTests
{
    public class InvalidPotionTest : Base
    {
        [Fact]
        public void ShouldThrow()
        {
            PotionBuilder
                .Setup(x => x.Validate())
                .Throws(new ValidationException(It.IsAny<string>()));

            Func<Task> action = async () => await Subject.Handle(Request, It.IsAny<CancellationToken>());

            action.Should().Throw<ValidationException>();
        }
    }
}