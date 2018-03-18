using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Magic
{
    public class DestructionSkill : Skill<MagicSpecialization>
    {
        public DestructionSkill()
            : base("Destruction")
        {
        }
    }

    public partial class MagicSkills
    {
        public DestructionSkill Destruction { get; } = new DestructionSkill();
    }
}