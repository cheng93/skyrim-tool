using System;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy
{
    public interface IAlchemyOptions
    {
        IIngredientCollection Ingredients { get; set; }

        IAlchemyPerkCollection Perks { get; set; }
    }

    public class AlchemyOptions : IAlchemyOptions
    {
        private IIngredientCollection ingredients = new IngredientCollection();

        public IIngredientCollection Ingredients
        {
            get => ingredients;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                ingredients = value;
            }
        }

        private IAlchemyPerkCollection perks = new AlchemyPerkCollection();

        public IAlchemyPerkCollection Perks
        {
            get => perks;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                perks = value;
            }
        }
    }
}