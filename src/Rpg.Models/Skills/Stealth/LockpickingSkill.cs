using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Stealth
{
    public class LockpickingSkill : Skill<StealthSpecialization>
    {
        public LockpickingSkill()
            : base("Lockpicking")
        {
        }
    }

    public partial class StealthSkills
    {
        public LockpickingSkill Lockpicking { get; } = new LockpickingSkill();
    }
}