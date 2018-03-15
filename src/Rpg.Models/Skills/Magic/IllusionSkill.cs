namespace Rpg.Models.Skills.Magic
{
    public class IllusionSkill : MagicSkill
    {
        public IllusionSkill()
            : base("Illusion")
        {
        }
    }

    public partial class MagicSkills
    {
        public IllusionSkill Illusion { get; } = new IllusionSkill();
    }
}