using System;
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

        IEffect Effect { get; }
    }

    public abstract class AlchemyEffect : IAlchemyEffect
    {
        protected AlchemyEffect(
            IEffect effect,
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

        public IEffect Effect { get; }

        public double Cost { get; }

        public double Duration { get; }

        public double Magnitude { get; }
    }

    public abstract class AlchemyEffect<T> : AlchemyEffect
        where T : class, IEffect
    {
        public AlchemyEffect(
            T effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public new T Effect => (T) base.Effect;
    }
}