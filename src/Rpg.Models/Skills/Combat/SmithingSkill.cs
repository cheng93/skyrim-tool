using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Combat
{
    public class SmithingSkill : Skill<CombatSpecialization>
    {
        public SmithingSkill()
            : base("Smithing")
        {
        }
    }

    public partial class CombatSkills
    {
        public SmithingSkill Smithing { get; } = new SmithingSkill();
    }
}