namespace Rpg.Models.Skills.Magic
{
    public class AlterationSkill : MagicSkill
    {
        public AlterationSkill()
            : base("Alteration")
        {
        }
    }

    public partial class MagicSkills
    {
        public AlterationSkill Alteration { get; } = new AlterationSkill();
    }
}