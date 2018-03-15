namespace Rpg.Models.Skills.Magic
{
    public class ConjurationSkill : MagicSkill
    {
        public ConjurationSkill()
            : base("Conjuration")
        {
        }
    }

    public partial class MagicSkills
    {
        public ConjurationSkill Conjuration { get; } = new ConjurationSkill();
    }
}