using Rpg.Models.Skills.Combat;
using Rpg.Models.Skills.Magic;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Skills
{
    public static class AllSkills
    {
        public static readonly CombatSkills Combat = new CombatSkills();

        public static readonly MagicSkills Magic = new MagicSkills();

        public static readonly StealthSkills Stealth = new StealthSkills();
    }
}