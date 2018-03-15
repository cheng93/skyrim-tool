namespace Rpg.Models.Skills.Combat
{
    public class SmithingSkill : CombatSkill
    {
        public SmithingSkill()
            : base("Smithing")
        {
        }
    }

    public partial class CombatSkills
    {
        public SmithingSkill Smithing { get; } = new SmithingSkill();
    }
}