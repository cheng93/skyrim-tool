using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Magic
{
    public class AlterationSkill : Skill<MagicSpecialization>
    {
        public AlterationSkill()
            : base("Alteration")
        {
        }
    }

    public partial class MagicSkills
    {
        public AlterationSkill Alteration { get; } = new AlterationSkill();
    }
}