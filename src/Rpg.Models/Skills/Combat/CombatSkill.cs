using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Combat
{
    public abstract class CombatSkill : ISkill<CombatSpecialization>
    {
        protected CombatSkill(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}