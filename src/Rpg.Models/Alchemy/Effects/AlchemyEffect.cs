using System;
using Rpg.Models.Common;
using Rpg.Models.Effects;

namespace Rpg.Models.Alchemy.Effects
{
    public interface IAlchemyEffect : IHasName, IHasId
    {
        double Cost { get; }

        double Duration { get; }

        double Magnitude { get; }

        bool IsPositiveEffect { get; }

        IEffect Effect { get; }
    }

    public abstract class AlchemyEffect : IAlchemyEffect
    {
        protected AlchemyEffect()
        {
        }

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

        public abstract string Id { get; }

        public IEffect Effect { get; internal set; }

        public double Cost { get; internal set; }

        public double Duration { get; internal set; }

        public double Magnitude { get; internal set; }

        public override bool Equals(object obj)
        {
            return obj is AlchemyEffect effect
                ? Id == effect.Id
                : false;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }

    public abstract class AlchemyEffect<T> : AlchemyEffect
        where T : class, IEffect
    {
        protected AlchemyEffect()
        {
        }

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