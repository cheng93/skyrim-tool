using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Magic
{
    public class ConjurationSkill : Skill<MagicSpecialization>
    {
        public ConjurationSkill()
            : base("Conjuration")
        {
        }
    }

    public partial class MagicSkills
    {
        public ConjurationSkill Conjuration { get; } = new ConjurationSkill();
    }
}