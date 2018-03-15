namespace Rpg.Models.Skills.Stealth
{
    public class LightArmorSkill : StealthSkill
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