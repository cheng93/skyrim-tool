using Rpg.Models.Common;
using Rpg.Models.Effects;

namespace Rpg.Models.Alchemy.Effects
{
    public interface IAlchemyEffect : IHasName, IHasDescription, IHasId
    {
        double Cost { get; }

        double Duration { get; }

        double Magnitude { get; }

        bool IsPositiveEffect { get; }
    }

    public abstract class AlchemyEffect<T> : IAlchemyEffect
        where T : Effect<T>
    {
        public AlchemyEffect(
            T effect,
            double cost,
            double duration,
            double magnitude)
        {
            Effect = effect;
            Cost = cost;
            Duration = duration;
            Magnitude = magnitude;
        }

        public abstract bool IsPositiveEffect { get; }

        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract string Id { get; }

        public T Effect { get; }

        public double Cost { get; }

        public double Duration { get; }

        public double Magnitude { get; }
    }
}