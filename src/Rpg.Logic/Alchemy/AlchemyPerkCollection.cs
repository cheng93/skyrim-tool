using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy
{
    public interface IAlchemyPerkCollection : IEnumerable<IPerk<AlchemySkill>>
    {
        void Add(IPerk<AlchemySkill> perk);
    }

    public class AlchemyPerkCollection : IAlchemyPerkCollection
    {
        private List<IPerk<AlchemySkill>> perks = new List<IPerk<AlchemySkill>>();

        public IEnumerator<IPerk<AlchemySkill>> GetEnumerator() => perks.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Add(IPerk<AlchemySkill> perk)
        {            
            if (perks.Any(x => perk.GetType() == x.GetType()))
            {
                throw new ArgumentException();
            }

            perks.Add(perk);
        }
    }
}