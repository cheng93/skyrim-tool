using System;
using System.Collections.Generic;
using System.Linq;
using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy
{
    internal interface IAlchemyOptions
    {
        int AlchemyLevel { get; set; }

        double FortifyAlchemyPercent { get; set; }

        IEnumerable<IIngredient> Ingredients { get; set; }

        IEnumerable<IPerk<AlchemySkill>> Perks { get; set; }
    }

    internal class AlchemyOptions : IAlchemyOptions
    {
        public int AlchemyLevel { get; set; } = SkillConstants.MinLevel;

        public double FortifyAlchemyPercent { get; set; } = 0;

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