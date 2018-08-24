using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR.Pipeline;

namespace Rpg.Commands.Pipeline
{
    public abstract class ValidationPreProcessor<TRequest> : AbstractValidator<TRequest>, IRequestPreProcessor<TRequest>
    {
        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            return this.ValidateAndThrowAsync(request);
        }
    }
}