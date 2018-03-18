using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Combat
{
    public class BlockSkill : Skill<CombatSpecialization>
    {
        public BlockSkill()
            : base("Block")
        {
        }
    }

    public partial class CombatSkills
    {
        public BlockSkill Block { get; } = new BlockSkill();
    }
}