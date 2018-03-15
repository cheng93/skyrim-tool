namespace Rpg.Models.Skills.Combat
{
    public class HeavyArmorSkill : CombatSkill
    {
        public HeavyArmorSkill()
            : base("Heavy Armor")
        {
        }
    }

    public partial class CombatSkills
    {
        public HeavyArmorSkill HeavyArmor { get; } = new HeavyArmorSkill();
    }
}