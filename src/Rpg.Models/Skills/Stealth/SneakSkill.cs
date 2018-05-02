using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Stealth
{
    public class SneakSkill : Skill<StealthSpecialization>
    {
        public SneakSkill()
            : base("Sneak")
        {
        }
    }

    public partial class StealthSkills
    {
        public SneakSkill Sneak { get; } = new SneakSkill();
    }
}