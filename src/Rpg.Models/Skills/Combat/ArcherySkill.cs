namespace Rpg.Models.Skills.Combat
{
    public class ArcherySkill : CombatSkill
    {
        public ArcherySkill()
            : base("Archery")
        {
        }
    }

    public partial class CombatSkills
    {
        public ArcherySkill Archery { get; } = new ArcherySkill();
    }
}