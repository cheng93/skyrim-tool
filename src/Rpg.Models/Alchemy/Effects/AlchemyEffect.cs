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

    public abstract class AlchemyEffect : IAlchemyEffect, IEquatable<AlchemyEffect>
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
            Cost = cost;
            Duration = duration;
            Magnitude = magnitude;
        }

        public abstract bool IsPositiveEffect { get; }

        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract string Id { get; }

        public IEffect Effect { get; internal set; }

        public double Cost { get; internal set; }

        public double Duration { get; internal set; }

        public double Magnitude { get; internal set; }

        public override bool Equals(object obj)
        {
            return obj is AlchemyEffect effect
                ? Equals(effect)
                : false;
        }

        public bool Equals(AlchemyEffect other)
        {
            return other != null
                ? Id == other.Id
                : false;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }

    public abstract class AlchemyEffect<T> : AlchemyEffect
        where T : IEffect
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
            Effect = effect;
        }

        public new T Effect { get; internal set; }
    }
}