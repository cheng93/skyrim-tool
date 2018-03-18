using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Magic
{
    public class RestorationSkill : Skill<MagicSpecialization>
    {
        public RestorationSkill()
            : base("Restoration")
        {
        }
    }

    public partial class MagicSkills
    {
        public RestorationSkill Restoration { get; } = new RestorationSkill();
    }
}