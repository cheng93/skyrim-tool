using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Combat
{
    public class HeavyArmorSkill : Skill<CombatSpecialization>
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