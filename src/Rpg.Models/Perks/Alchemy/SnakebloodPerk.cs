using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class SnakebloodPerk : Perk<AlchemySkill>
    {
        public SnakebloodPerk()
            : base("Snakeblood")
        {
            Description = "50% resistance to all poisons.";
        }

        public override string Description { get; }
    }

    public partial class AlchemyPerks
    {
        public SnakebloodPerk Snakeblood { get; } = new SnakebloodPerk();
    }
}