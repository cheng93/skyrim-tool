using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class GreenThumbPerk : Perk<AlchemySkill>
    {
        public GreenThumbPerk()
            : base("Green Thumb")
        {
            Description = "Two ingredients are gathered from plants.";
        }

        public override string Description { get; }
    }

    public partial class AlchemyPerks
    {
        public GreenThumbPerk GreenThumb { get; } = new GreenThumbPerk();
    }
}