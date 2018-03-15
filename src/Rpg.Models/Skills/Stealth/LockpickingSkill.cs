namespace Rpg.Models.Skills.Stealth
{
    public class LockpickingSkill : StealthSkill
    {
        public LockpickingSkill()
            : base("Lockpicking")
        {
        }
    }

    public partial class StealthSkills
    {
        public LockpickingSkill Lockpicking { get; } = new LockpickingSkill();
    }
}