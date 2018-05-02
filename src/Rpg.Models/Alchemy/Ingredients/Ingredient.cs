using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Common;

namespace Rpg.Models.Alchemy.Ingredients
{
    public interface IIngredient : IHasName, IHasId
    {
        IAlchemyEffect PrimaryEffect { get; }

        IAlchemyEffect SecondaryEffect { get; }

        IAlchemyEffect TertiaryEffect { get; }

        IAlchemyEffect QuaternaryEffect { get; }

        IEnumerable<IAlchemyEffect> CombinedEffects { get; }
    }

    public abstract class Ingredient : IIngredient
    {
        public abstract string Name { get; }

        public abstract string Id { get; }

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