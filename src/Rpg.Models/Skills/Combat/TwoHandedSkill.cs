using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Combat
{
    public class TwoHandedSkill : Skill<CombatSpecialization>
    {
        public TwoHandedSkill()
            : base("Two-Handed")
        {
        }
    }

    public partial class CombatSkills
    {
        public TwoHandedSkill TwoHanded { get; } = new TwoHandedSkill();
    }
}