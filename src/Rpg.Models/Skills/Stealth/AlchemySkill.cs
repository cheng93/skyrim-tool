using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Stealth
{
    public class AlchemySkill : Skill<StealthSpecialization>
    {
        public AlchemySkill()
            : base("Alchemy")
        {
        }
    }

    public partial class StealthSkills
    {
        public AlchemySkill Alchemy { get; } = new AlchemySkill();
    }
}