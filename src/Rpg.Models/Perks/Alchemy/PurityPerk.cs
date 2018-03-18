using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class PurityPerk : Perk<AlchemySkill>
    {
        public PurityPerk()
            : base("Purity")
        {
            Description = "All negative effects are removed from created potions, and all positive effects are removed from created poisons.";
        }

        public override string Description { get; }
    }

    public partial class AlchemyPerks
    {
        public PurityPerk Purity { get; } = new PurityPerk();
    }
}