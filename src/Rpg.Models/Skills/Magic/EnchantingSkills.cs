namespace Rpg.Models.Skills.Magic
{
    public class EnchantingSkill : MagicSkill
    {
        public EnchantingSkill()
            : base("Enchanting")
        {
        }
    }

    public partial class MagicSkills
    {
        public EnchantingSkill Enchanting { get; } = new EnchantingSkill();
    }
}