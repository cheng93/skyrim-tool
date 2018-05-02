using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Combat
{
    public class OneHandedSkill : Skill<CombatSpecialization>
    {
        public OneHandedSkill()
            : base("One-Handed")
        {
        }
    }

    public partial class CombatSkills
    {
        public OneHandedSkill OneHanded { get; } = new OneHandedSkill();
    }
}