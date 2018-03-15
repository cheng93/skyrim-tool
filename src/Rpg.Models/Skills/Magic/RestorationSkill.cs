namespace Rpg.Models.Skills.Magic
{
    public class RestorationSkill : MagicSkill
    {
        public RestorationSkill()
            : base("Restoration")
        {
        }
    }

    public partial class MagicSkills
    {
        public RestorationSkill Restoration { get; } = new RestorationSkill();
    }
}