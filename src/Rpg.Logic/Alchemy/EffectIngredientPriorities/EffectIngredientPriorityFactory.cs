using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Common;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal interface IEffectIngredientPriorityFactory
    {
        IEffectIngredientPriority Create(IAlchemyEffect effect);
    }
    internal class EffectIngredientPriorityFactory : IEffectIngredientPriorityFactory
    {
        private Dictionary<IAlchemyEffect, IEffectIngredientPriority> effectMap = 
            new Dictionary<IAlchemyEffect, IEffectIngredientPriority>(new IHasIdEqualityComparer())
        {
            {AllAlchemyEffects.CureDisease, new CureDiseaseIngredientPriority()},
            {AllAlchemyEffects.DamageHealth, new DamageHealthIngredientPriority()},
            {AllAlchemyEffects.DamageMagicka, new DamageMagickaIngredientPriority()},
            {AllAlchemyEffects.DamageStamina, new DamageStaminaIngredientPriority()},
            {AllAlchemyEffects.DamageMagickaRegeneration, new DamageMagickaRegenerationIngredientPriority()},
            {AllAlchemyEffects.DamageStaminaRegeneration, new DamageStaminaRegenerationIngredientPriority()},
            {AllAlchemyEffects.Fear, new FearIngredientPriority()},
            {AllAlchemyEffects.FortifyHealth, new FortifyHealthIngredientPriority()},
            {AllAlchemyEffects.FortifyMagicka, new FortifyMagickaIngredientPriority()},
            {AllAlchemyEffects.FortifyStamina, new FortifyStaminaIngredientPriority()},
            {AllAlchemyEffects.FortifyCarryWeight, new FortifyCarryWeightIngredientPriority()},
            {AllAlchemyEffects.FortifyAlteration, new FortifyAlterationIngredientPriority()},
            {AllAlchemyEffects.FortifyArchery, new FortifyArcheryIngredientPriority()},
            {AllAlchemyEffects.FortifyBarter, new FortifyBarterIngredientPriority()},
            {AllAlchemyEffects.FortifyBlock, new FortifyBlockIngredientPriority()},
            {AllAlchemyEffects.FortifyConjuration, new FortifyConjurationIngredientPriority()},
            {AllAlchemyEffects.FortifyDestruction, new FortifyDestructionIngredientPriority()},
            {AllAlchemyEffects.FortifyEnchanting, new FortifyEnchantingIngredientPriority()},
            {AllAlchemyEffects.FortifyHeavyArmor, new FortifyHeavyArmorIngredientPriority()},
            {AllAlchemyEffects.FortifyIllusion, new FortifyIllusionIngredientPriority()},
            {AllAlchemyEffects.FortifyLightArmor, new FortifyLightArmorIngredientPriority()},
            {AllAlchemyEffects.FortifyLockpicking, new FortifyLockpickingIngredientPriority()},
            {AllAlchemyEffects.FortifyOneHanded, new FortifyOneHandedIngredientPriority()},
            {AllAlchemyEffects.FortifyPickpocket, new FortifyPickpocketIngredientPriority()},
            {AllAlchemyEffects.FortifyRestoration, new FortifyRestorationIngredientPriority()},
            {AllAlchemyEffects.FortifySmithing, new FortifySmithingIngredientPriority()},
            {AllAlchemyEffects.FortifySneak, new FortifySneakIngredientPriority()},
            {AllAlchemyEffects.FortifyTwoHanded, new FortifyTwoHandedIngredientPriority()},
            {AllAlchemyEffects.Frenzy, new FrenzyIngredientPriority()},
            {AllAlchemyEffects.Invisibility, new InvisibilityIngredientPriority()},
            {AllAlchemyEffects.LingeringDamageHealth, new LingeringDamageHealthIngredientPriority()},
            {AllAlchemyEffects.LingeringDamageMagicka, new LingeringDamageMagickaIngredientPriority()},
            {AllAlchemyEffects.LingeringDamageStamina, new LingeringDamageStaminaIngredientPriority()},
            {AllAlchemyEffects.Paralyze, new ParalyzeIngredientPriority()},
            {AllAlchemyEffects.RavageHealth, new RavageHealthIngredientPriority()},
            {AllAlchemyEffects.RavageMagicka, new RavageMagickaIngredientPriority()},
            {AllAlchemyEffects.RavageStamina, new RavageStaminaIngredientPriority()},
            {AllAlchemyEffects.RegenerateHealth, new RegenerateHealthIngredientPriority()},
            {AllAlchemyEffects.RegenerateMagicka, new RegenerateMagickaIngredientPriority()},
            {AllAlchemyEffects.RegenerateStamina, new RegenerateStaminaIngredientPriority()},
            {AllAlchemyEffects.ResistFire, new ResistFireIngredientPriority()},
            {AllAlchemyEffects.ResistFrost, new ResistFrostIngredientPriority()},
            {AllAlchemyEffects.ResistShock, new ResistShockIngredientPriority()},
            {AllAlchemyEffects.ResistMagic, new ResistMagicIngredientPriority()},
            {AllAlchemyEffects.ResistPoison, new ResistPoisonIngredientPriority()},
            {AllAlchemyEffects.RestoreHealth, new RestoreHealthIngredientPriority()},
            {AllAlchemyEffects.RestoreMagicka, new RestoreMagickaIngredientPriority()},
            {AllAlchemyEffects.RestoreStamina, new RestoreStaminaIngredientPriority()},
            {AllAlchemyEffects.Slow, new SlowIngredientPriority()},
            {AllAlchemyEffects.Waterbreathing, new WaterbreathingIngredientPriority()},
            {AllAlchemyEffects.WeaknessToFire, new WeaknessToFireIngredientPriority()},
            {AllAlchemyEffects.WeaknessToFrost, new WeaknessToFrostIngredientPriority()},
            {AllAlchemyEffects.WeaknessToShock, new WeaknessToShockIngredientPriority()},
            {AllAlchemyEffects.WeaknessToMagic, new WeaknessToMagicIngredientPriority()},
            {AllAlchemyEffects.WeaknessToPoison, new WeaknessToPoisonIngredientPriority()}
        };

        public IEffectIngredientPriority Create(IAlchemyEffect effect) => effectMap[effect];
    }
}