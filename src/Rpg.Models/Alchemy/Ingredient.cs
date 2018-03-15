using System.Collections.Generic;
using Rpg.Models.Common;

namespace Rpg.Models.Alchemy
{
    public interface IIngredient
    {
        IAlchemyEffect PrimaryEffect { get; }

        IAlchemyEffect SecondaryEffect { get; }

        IAlchemyEffect TertiaryEffect { get; }

        IAlchemyEffect QuaternaryEffect { get; }

        IEnumerable<IAlchemyEffect> CombinedEffects { get; }
    }

    public abstract class Ingredient : IIngredient, IHasName
    {
        public abstract string Name { get; }

        public abstract IAlchemyEffect PrimaryEffect { get; }

        public abstract IAlchemyEffect SecondaryEffect { get; }

        public abstract IAlchemyEffect TertiaryEffect { get; }

        public abstract IAlchemyEffect QuaternaryEffect { get; }

        public IEnumerable<IAlchemyEffect> CombinedEffects => new[]
        {
            PrimaryEffect,
            SecondaryEffect,
            TertiaryEffect,
            QuaternaryEffect
        };
    }
}