using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class PoisonerPerk : Perk<AlchemySkill>
    {
        public PoisonerPerk()
            : base("Poisoner")
        {
            Description = "Poisons you mix are 25% more effective.";
        }

        public override string Description { get; }
    }

    public partial class AlchemyPerks
    {
        public PoisonerPerk Poisoner { get; } = new PoisonerPerk();
    }
}