namespace Rpg.Models.Skills.Combat
{
    public class TwoHandedSkill : CombatSkill
    {
        public TwoHandedSkill()
            : base("Two-Handed")
        {
        }
    }

    public partial class CombatSkills
    {
        public TwoHandedSkill TwoHanded { get; } = new TwoHandedSkill();
    }
}