namespace Rpg.Models.Skills.Stealth
{
    public class SneakSkill : StealthSkill
    {
        public SneakSkill()
            : base("Sneak")
        {
        }
    }

    public partial class StealthSkills
    {
        public SneakSkill Sneak { get; } = new SneakSkill();
    }
}