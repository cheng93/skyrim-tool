using System.Collections.Generic;
using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects;
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
            switch (Effect.Skill)
            {
                case Skill.Alchemy:
                case Skill.Persuasion:
                    throw new InvalidEnumArgumentException();
            }
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name => GetName(Effect.Skill);

        public override string Id => idMap[Effect.Skill];

        private string GetName(Skill skill)
        {
            switch (skill)
            {
                case Skill.Archery:
                    return "Fortify Marksman";
                default:
                    return $"Fortify {skill.ToPresentableString()}";
            }
        }

        private static Dictionary<Skill, string> idMap = new Dictionary<Skill, string>()
        {
            {Skill.Alteration, "0003EB24"},
            {Skill.Archery, "0003EB1B"},
            {Skill.Barter, "0003EB23"},
            {Skill.Block, "0003EB1C"},
            {Skill.Conjuration, "0003EB25"},
            {Skill.Destruction, "0003EB26"},
            {Skill.Enchanting, "0003EB29"},
            {Skill.HeavyArmor, "0003EB1E"},
            {Skill.Illusion, "0003EB27"},
            {Skill.LightArmor, "0003EB1F"},
            {Skill.Lockpicking, "0003EB21"},
            {Skill.OneHanded, "0003EB19"},
            {Skill.Pickpocket, "0003EB20"},
            {Skill.Restoration, "0003EB28"},
            {Skill.Smithing, "0003EB1D"},
            {Skill.Sneak, "0003EB22"},
            {Skill.TwoHanded, "0003EB1A"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly FortifySkillAlchemyEffect FortifyAlteration = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyAlteration,
            cost: 0.2,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifyArchery = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyArchery,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifyBarter = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyBarter,
            cost: 2,
            duration: 30,
            magnitude: 1
        );

        public static readonly FortifySkillAlchemyEffect FortifyBlock = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyBlock,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifyConjuration = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyConjuration,
            cost: 0.25,
            duration: 60,
            magnitude: 5
        );

        public static readonly FortifySkillAlchemyEffect FortifyDestruction = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyDestruction,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifyEnchanting = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyEnchanting,
            cost: 0.6,
            duration: 30,
            magnitude: 1
        );

        public static readonly FortifySkillAlchemyEffect FortifyHeavyArmor = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyHeavyArmor,
            cost: 0.5,
            duration: 60,
            magnitude: 2
        );

        public static readonly FortifySkillAlchemyEffect FortifyIllusion = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyIllusion,
            cost: 0.4,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifyLightArmor = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyLightArmor,
            cost: 0.5,
            duration: 60,
            magnitude: 2
        );

        public static readonly FortifySkillAlchemyEffect FortifyLockpicking = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyLockpicking,
            cost: 0.5,
            duration: 30,
            magnitude: 2
        );

        public static readonly FortifySkillAlchemyEffect FortifyOneHanded = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyOneHanded,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifyPickpocket = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyPickpocket,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifyRestoration = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyRestoration,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifySmithing = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifySmithing,
            cost: 0.75,
            duration: 30,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifySneak = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifySneak,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifySkillAlchemyEffect FortifyTwoHanded = new FortifySkillAlchemyEffect(
            AllEffects.Restoration.FortifyTwoHanded,
            cost: 0.5,
            duration: 60,
            magnitude: 4
        );
    }
}