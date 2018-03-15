using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Magic
{
    public class IllusionSkill : Skill<MagicSpecialization>
    {
        public IllusionSkill()
            : base("Illusion")
        {
        }
    }

    public partial class MagicSkills
    {
        public IllusionSkill Illusion { get; } = new IllusionSkill();
    }
}