using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Magic
{
    public class EnchantingSkill : Skill<MagicSpecialization>
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