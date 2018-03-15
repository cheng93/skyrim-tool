namespace Rpg.Models.Skills.Combat
{
    public class OneHandedSkill : CombatSkill
    {
        public OneHandedSkill()
            : base("One-Handed")
        {
        }
    }

    public partial class CombatSkills
    {
        public OneHandedSkill OneHanded { get; } = new OneHandedSkill();
    }
}