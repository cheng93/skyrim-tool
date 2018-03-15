namespace Rpg.Models.Skills.Magic
{
    public class DestructionSkill : MagicSkill
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