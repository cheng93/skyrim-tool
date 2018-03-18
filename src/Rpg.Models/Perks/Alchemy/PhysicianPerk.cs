using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class PhysicianPerk : Perk<AlchemySkill>
    {
        public PhysicianPerk()
            : base("Physician")
        {
            Description = "Potions you mix that restore Health, Magicka or Stamina are 25% more powerful.";
        }

        public override string Description { get; }
    }

    public partial class AlchemyPerks
    {
        public PhysicianPerk Physician { get; } = new PhysicianPerk();
    }
}