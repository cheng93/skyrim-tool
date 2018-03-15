namespace Rpg.Models.Skills.Stealth
{
    public class AlchemySkill : StealthSkill
    {
        public AlchemySkill()
            : base("Alchemy")
        {
        }
    }

    public partial class StealthSkills
    {
        public AlchemySkill Alchemy { get; } = new AlchemySkill();
    }
}