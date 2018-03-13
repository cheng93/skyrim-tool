using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects.Restoration;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class FortifySkillAlchemyEffect : AlchemyEffect<FortifySkillEffect>
    {
        public FortifySkillAlchemyEffect(
            FortifySkillEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            switch(Effect.Skill)
            {
                case Skill.Alchemy:
                case Skill.Persuasion:
                    throw new InvalidEnumArgumentException();
            }
            IsPositiveEffect = true;
            Name = GetName(Effect.Skill);
            Description = GetDescription(Effect.Skill);
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        private string GetName(Skill skill)
        {
            switch(skill)
            {
                case Skill.Archery:
                    return "Fortify Marksman";
                default:
                    return $"Fortify {skill.ToPresentableString()}";
            }
        }

        private string GetDescription(Skill skill)
        {
            switch(skill)
            {
                case Skill.Alteration:
                case Skill.Conjuration:
                    return $"{skill.ToPresentableString()} spells last {Magnitude}% longer for {Duration} seconds.";
                case Skill.Archery:
                    return $"Bows do {Magnitude}% more damage for {Duration} seconds.";
                case Skill.Barter:
                    return $"You haggle for {Magnitude}% better prices for {Duration} seconds.";
                case Skill.Block:
                    return $"Blocking absorbs {Magnitude}% more damage for {Duration} seconds.";
                case Skill.Destruction:
                case Skill.Illusion:
                case Skill.Restoration:
                    return $"{skill.ToPresentableString()} spells are {Magnitude}% stronger for {Duration} seconds.";
                case Skill.Enchanting:
                    return $"For {Duration} seconds, items are enchanted {Magnitude}% stronger.";
                case Skill.HeavyArmor:
                case Skill.LightArmor:
                    return $"Increase {skill.ToPresentableString()} skill by {Magnitude} points for {Duration} seconds.";
                case Skill.Lockpicking:
                    return $"Lockpicking is {Magnitude}% easier for {Duration} seconds.";
                case Skill.OneHanded:
                case Skill.TwoHanded:
                    return $"{skill.ToPresentableString()} weapons do {Magnitude}% more damage for {Duration} seconds.";
                case Skill.Pickpocket:
                    return $"Pickpocket is {Magnitude}% easier for {Duration} seconds.";
                case Skill.Smithing:
                    return $"For {Duration} seconds, weapon and armor improving is {Magnitude}% better.";
                case Skill.Sneak:
                    return $"You are {Magnitude}% harder to detect for {Duration} seconds.";
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}