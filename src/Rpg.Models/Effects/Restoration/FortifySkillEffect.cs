using Rpg.Models.Common.Enums;

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
        public FortifySkillEffect FortifyAlchemy { get; } = new FortifySkillEffect(Skill.Alchemy);

        public FortifySkillEffect FortifyAlteration { get; } = new FortifySkillEffect(Skill.Alteration);

        public FortifySkillEffect FortifyArchery { get; } = new FortifySkillEffect(Skill.Archery);

        public FortifySkillEffect FortifyBarter { get; } = new FortifySkillEffect(Skill.Barter);

        public FortifySkillEffect FortifyBlock { get; } = new FortifySkillEffect(Skill.Block);

        public FortifySkillEffect FortifyConjuration { get; } = new FortifySkillEffect(Skill.Conjuration);

        public FortifySkillEffect FortifyDestruction { get; } = new FortifySkillEffect(Skill.Destruction);

        public FortifySkillEffect FortifyEnchanting { get; } = new FortifySkillEffect(Skill.Enchanting);

        public FortifySkillEffect FortifyHeavyArmor { get; } = new FortifySkillEffect(Skill.HeavyArmor);

        public FortifySkillEffect FortifyIllusion { get; } = new FortifySkillEffect(Skill.Illusion);

        public FortifySkillEffect FortifyLightArmor { get; } = new FortifySkillEffect(Skill.LightArmor);

        public FortifySkillEffect FortifyLockpicking { get; } = new FortifySkillEffect(Skill.Lockpicking);

        public FortifySkillEffect FortifyOneHanded { get; } = new FortifySkillEffect(Skill.OneHanded);

        public FortifySkillEffect FortifyPersuasion { get; } = new FortifySkillEffect(Skill.Persuasion);

        public FortifySkillEffect FortifyPickpocket { get; } = new FortifySkillEffect(Skill.Pickpocket);

        public FortifySkillEffect FortifyRestoration { get; } = new FortifySkillEffect(Skill.Restoration);

        public FortifySkillEffect FortifySmithing { get; } = new FortifySkillEffect(Skill.Smithing);

        public FortifySkillEffect FortifySneak { get; } = new FortifySkillEffect(Skill.Sneak);

        public FortifySkillEffect FortifyTwoHanded { get; } = new FortifySkillEffect(Skill.TwoHanded);
    }
}