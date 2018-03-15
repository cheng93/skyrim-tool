using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Stealth
{
    public class PickpocketSkill : Skill<StealthSpecialization>
    {
        public PickpocketSkill()
            : base("Pickpocket")
        {
        }
    }

    public partial class StealthSkills
    {
        public PickpocketSkill Pickpocket { get; } = new PickpocketSkill();
    }
}