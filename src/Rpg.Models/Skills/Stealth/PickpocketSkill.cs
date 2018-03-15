namespace Rpg.Models.Skills.Stealth
{
    public class PickpocketSkill : StealthSkill
    {
        public PickpocketSkill()
            : base("Pickpocket")
        {
        }
    }

    public partial class StealthSkills
    {
        public PickpocketSkill Pickpocket { get; } = new PickpocketSkill();
    }
}