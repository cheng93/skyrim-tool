using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Combat
{
    public class ArcherySkill : Skill<CombatSpecialization>
    {
        public ArcherySkill()
            : base("Archery")
        {
        }
    }

    public partial class CombatSkills
    {
        public ArcherySkill Archery { get; } = new ArcherySkill();
    }
}