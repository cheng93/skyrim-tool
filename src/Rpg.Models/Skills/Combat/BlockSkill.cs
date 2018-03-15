namespace Rpg.Models.Skills.Combat
{
    public class BlockSkill : CombatSkill
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