using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class BenefactorPerk : Perk<AlchemySkill>
    {
        public BenefactorPerk()
            : base("Benefactor")
        {
            Description = "Potions you mix with beneficial effects have an additional 25% greater magnitude.";
        }

        public override string Description { get; }
    }

    public partial class AlchemyPerks
    {
        public BenefactorPerk Benefactor { get; } = new BenefactorPerk();
    }
}