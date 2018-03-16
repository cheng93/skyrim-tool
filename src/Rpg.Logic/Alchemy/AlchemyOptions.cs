using System;
using System.Collections.Generic;
using System.Linq;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy
{
    public interface IAlchemyOptions
    {
        IEnumerable<IIngredient> Ingredients { get; set; }

        IEnumerable<IPerk<AlchemySkill>> Perks { get; set; }
    }

    public class AlchemyOptions : IAlchemyOptions
    {
        private IEnumerable<IIngredient> ingredients = Enumerable.Empty<IIngredient>();

        public IEnumerable<IIngredient> Ingredients
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

        private IEnumerable<IPerk<AlchemySkill>> perks = Enumerable.Empty<IPerk<AlchemySkill>>();

        public IEnumerable<IPerk<AlchemySkill>> Perks
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