using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Stealth
{
    public class LightArmorSkill : Skill<StealthSpecialization>
    {
        public LightArmorSkill()
            : base("Light Armor")
        {
        }
    }

    public partial class StealthSkills
    {
        public LightArmorSkill LightArmor { get; } = new LightArmorSkill();
    }
}