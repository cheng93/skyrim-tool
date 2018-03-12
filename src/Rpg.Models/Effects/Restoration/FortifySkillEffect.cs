using Rpg.Models.Effects.Enums;

namespace Rpg.Models.Effects.Restoration
{
    public class FortifySkillEffect : Effect<FortifySkillEffect>
    {
        public FortifySkillEffect(Skill skill)
            : base($"Fortify {skill.ToString()}")
        {
            Skill = skill;
        }

        public Skill Skill { get; }
    }

    public partial class RestorationEffects 
    {
        public static readonly FortifySkillEffect FortifyAlchemy = new FortifySkillEffect(Skill.Alchemy);

        public static readonly FortifySkillEffect FortifyAlteration = new FortifySkillEffect(Skill.Alteration);

        public static readonly FortifySkillEffect FortifyArchery = new FortifySkillEffect(Skill.Archery);

        public static readonly FortifySkillEffect FortifyBarter = new FortifySkillEffect(Skill.Barter);

        public static readonly FortifySkillEffect FortifyBlock = new FortifySkillEffect(Skill.Block);

        public static readonly FortifySkillEffect FortifyConjuration = new FortifySkillEffect(Skill.Conjuration);

        public static readonly FortifySkillEffect FortifyDestruction = new FortifySkillEffect(Skill.Destruction);

        public static readonly FortifySkillEffect FortifyEnchanting = new FortifySkillEffect(Skill.Enchanting);

        public static readonly FortifySkillEffect FortifyHeavyArmor = new FortifySkillEffect(Skill.HeavyArmor);

        public static readonly FortifySkillEffect FortifyIllusion = new FortifySkillEffect(Skill.Illusion);

        public static readonly FortifySkillEffect FortifyLightArmor = new FortifySkillEffect(Skill.LightArmor);

        public static readonly FortifySkillEffect FortifyLockpicking = new FortifySkillEffect(Skill.Lockpicking);

        public static readonly FortifySkillEffect FortifyOneHanded = new FortifySkillEffect(Skill.OneHanded);

        public static readonly FortifySkillEffect FortifyPersuasion = new FortifySkillEffect(Skill.Persuasion);

        public static readonly FortifySkillEffect FortifyPickpocket = new FortifySkillEffect(Skill.Pickpocket);

        public static readonly FortifySkillEffect FortifyRestoration = new FortifySkillEffect(Skill.Restoration);

        public static readonly FortifySkillEffect FortifySmithing = new FortifySkillEffect(Skill.Smithing);

        public static readonly FortifySkillEffect FortifySneak = new FortifySkillEffect(Skill.Sneak);

        public static readonly FortifySkillEffect FortifySpells = new FortifySkillEffect(Skill.Spells);

        public static readonly FortifySkillEffect FortifyTwoHanded = new FortifySkillEffect(Skill.TwoHanded);
    }
}