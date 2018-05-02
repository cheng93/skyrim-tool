using System;
using Rpg.Models.Common;
using Rpg.Models.Effects;

namespace Rpg.Models.Alchemy.Effects
{
    public interface IAlchemyEffect : IHasName, IHasDescription, IHasId
    {
        decimal Cost { get; }

        decimal Duration { get; }

        decimal Magnitude { get; }

        bool IsPositiveEffect { get; }

        IEffect Effect { get; }
    }

    public abstract class AlchemyEffect : IAlchemyEffect
    {
        protected AlchemyEffect(
            IEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
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

        public decimal Cost { get; }

        public decimal Duration { get; }

        public decimal Magnitude { get; }
    }

    public abstract class AlchemyEffect<T> : AlchemyEffect
        where T : class, IEffect
    {
        public AlchemyEffect(
            T effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public new T Effect => (T) base.Effect;
    }
}