using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class ConcentratedPoisonPerk : Perk<AlchemySkill>
    {
        public ConcentratedPoisonPerk()
            : base("Concentrated Poison")
        {
            Description = "Poisons applied to weapons last for twice as many hits.";
        }

        public override string Description { get; }
    }

    public partial class AlchemyPerks
    {
        public ConcentratedPoisonPerk ConcentratedPoison { get; } = new ConcentratedPoisonPerk();
    }
}