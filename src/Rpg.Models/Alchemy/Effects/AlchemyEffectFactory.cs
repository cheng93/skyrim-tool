using System;
using System.Collections.Generic;

namespace Rpg.Models.Alchemy.Effects
{
    public interface IAlchemyEffectFactory
    {
        IAlchemyEffect Create(IAlchemyEffect e, double cost, double duration, double magnitude);
    }

    public class AlchemyEffectFactory : IAlchemyEffectFactory
    {
        private static readonly Dictionary<IAlchemyEffect, Func<double, double, double, IAlchemyEffect>> map
            = new Dictionary<IAlchemyEffect, Func<double, double, double, IAlchemyEffect>>()
        {
            {AllAlchemyEffects.CureDisease, (double c, double d, double m) => AllAlchemyEffects.CureDisease.Create(c, d, m)},
            {AllAlchemyEffects.DamageHealth, (double c, double d, double m) => AllAlchemyEffects.DamageHealth.Create(c, d, m)},
            {AllAlchemyEffects.DamageMagicka, (double c, double d, double m) => AllAlchemyEffects.DamageMagicka.Create(c, d, m)},
            {AllAlchemyEffects.DamageStamina, (double c, double d, double m) => AllAlchemyEffects.DamageStamina.Create(c, d, m)},
            {AllAlchemyEffects.DamageMagickaRegeneration, (double c, double d, double m) => AllAlchemyEffects.DamageMagickaRegeneration.Create(c, d, m)},
            {AllAlchemyEffects.DamageStaminaRegeneration, (double c, double d, double m) => AllAlchemyEffects.DamageStaminaRegeneration.Create(c, d, m)},
            {AllAlchemyEffects.Fear, (double c, double d, double m) => AllAlchemyEffects.Fear.Create(c, d, m)},
            {AllAlchemyEffects.FortifyHealth, (double c, double d, double m) => AllAlchemyEffects.FortifyHealth.Create(c, d, m)},
            {AllAlchemyEffects.FortifyMagicka, (double c, double d, double m) => AllAlchemyEffects.FortifyMagicka.Create(c, d, m)},
            {AllAlchemyEffects.FortifyStamina, (double c, double d, double m) => AllAlchemyEffects.FortifyStamina.Create(c, d, m)},
            {AllAlchemyEffects.FortifyCarryWeight, (double c, double d, double m) => AllAlchemyEffects.FortifyCarryWeight.Create(c, d, m)},
            {AllAlchemyEffects.FortifyAlteration, (double c, double d, double m) => AllAlchemyEffects.FortifyAlteration.Create(c, d, m)},
            {AllAlchemyEffects.FortifyArchery, (double c, double d, double m) => AllAlchemyEffects.FortifyArchery.Create(c, d, m)},
            {AllAlchemyEffects.FortifyBarter, (double c, double d, double m) => AllAlchemyEffects.FortifyBarter.Create(c, d, m)},
            {AllAlchemyEffects.FortifyBlock, (double c, double d, double m) => AllAlchemyEffects.FortifyBlock.Create(c, d, m)},
            {AllAlchemyEffects.FortifyConjuration, (double c, double d, double m) => AllAlchemyEffects.FortifyConjuration.Create(c, d, m)},
            {AllAlchemyEffects.FortifyDestruction, (double c, double d, double m) => AllAlchemyEffects.FortifyDestruction.Create(c, d, m)},
            {AllAlchemyEffects.FortifyEnchanting, (double c, double d, double m) => AllAlchemyEffects.FortifyEnchanting.Create(c, d, m)},
            {AllAlchemyEffects.FortifyHeavyArmor, (double c, double d, double m) => AllAlchemyEffects.FortifyHeavyArmor.Create(c, d, m)},
            {AllAlchemyEffects.FortifyIllusion, (double c, double d, double m) => AllAlchemyEffects.FortifyIllusion.Create(c, d, m)},
            {AllAlchemyEffects.FortifyLockpicking, (double c, double d, double m) => AllAlchemyEffects.FortifyLockpicking.Create(c, d, m)},
            {AllAlchemyEffects.FortifyOneHanded, (double c, double d, double m) => AllAlchemyEffects.FortifyOneHanded.Create(c, d, m)},
            {AllAlchemyEffects.FortifyPickpocket, (double c, double d, double m) => AllAlchemyEffects.FortifyPickpocket.Create(c, d, m)},
            {AllAlchemyEffects.FortifyRestoration, (double c, double d, double m) => AllAlchemyEffects.FortifyRestoration.Create(c, d, m)},
            {AllAlchemyEffects.FortifySmithing, (double c, double d, double m) => AllAlchemyEffects.FortifySmithing.Create(c, d, m)},
            {AllAlchemyEffects.FortifySneak, (double c, double d, double m) => AllAlchemyEffects.FortifySneak.Create(c, d, m)},
            {AllAlchemyEffects.FortifyTwoHanded, (double c, double d, double m) => AllAlchemyEffects.FortifyTwoHanded.Create(c, d, m)},
            {AllAlchemyEffects.Frenzy, (double c, double d, double m) => AllAlchemyEffects.Frenzy.Create(c, d, m)},
            {AllAlchemyEffects.Invisibility, (double c, double d, double m) => AllAlchemyEffects.Invisibility.Create(c, d, m)},
            {AllAlchemyEffects.LingeringDamageHealth, (double c, double d, double m) => AllAlchemyEffects.LingeringDamageHealth.Create(c, d, m)},
            {AllAlchemyEffects.LingeringDamageMagicka, (double c, double d, double m) => AllAlchemyEffects.LingeringDamageMagicka.Create(c, d, m)},
            {AllAlchemyEffects.LingeringDamageStamina, (double c, double d, double m) => AllAlchemyEffects.LingeringDamageStamina.Create(c, d, m)},
            {AllAlchemyEffects.Paralyze, (double c, double d, double m) => AllAlchemyEffects.Paralyze.Create(c, d, m)},
            {AllAlchemyEffects.RavageHealth, (double c, double d, double m) => AllAlchemyEffects.RavageHealth.Create(c, d, m)},
            {AllAlchemyEffects.RavageMagicka, (double c, double d, double m) => AllAlchemyEffects.RavageMagicka.Create(c, d, m)},
            {AllAlchemyEffects.RavageStamina, (double c, double d, double m) => AllAlchemyEffects.RavageStamina.Create(c, d, m)},
            {AllAlchemyEffects.RegenerateHealth, (double c, double d, double m) => AllAlchemyEffects.RegenerateHealth.Create(c, d, m)},
            {AllAlchemyEffects.RegenerateMagicka, (double c, double d, double m) => AllAlchemyEffects.RegenerateMagicka.Create(c, d, m)},
            {AllAlchemyEffects.RegenerateStamina, (double c, double d, double m) => AllAlchemyEffects.RegenerateStamina.Create(c, d, m)},
            {AllAlchemyEffects.ResistFire, (double c, double d, double m) => AllAlchemyEffects.ResistFire.Create(c, d, m)},
            {AllAlchemyEffects.ResistFrost, (double c, double d, double m) => AllAlchemyEffects.ResistFrost.Create(c, d, m)},
            {AllAlchemyEffects.ResistShock, (double c, double d, double m) => AllAlchemyEffects.ResistShock.Create(c, d, m)},
            {AllAlchemyEffects.ResistMagic, (double c, double d, double m) => AllAlchemyEffects.ResistMagic.Create(c, d, m)},
            {AllAlchemyEffects.ResistPoison, (double c, double d, double m) => AllAlchemyEffects.ResistPoison.Create(c, d, m)},
            {AllAlchemyEffects.RestoreHealth, (double c, double d, double m) => AllAlchemyEffects.RestoreHealth.Create(c, d, m)},
            {AllAlchemyEffects.RestoreMagicka, (double c, double d, double m) => AllAlchemyEffects.RestoreMagicka.Create(c, d, m)},
            {AllAlchemyEffects.RestoreStamina, (double c, double d, double m) => AllAlchemyEffects.RestoreStamina.Create(c, d, m)},
            {AllAlchemyEffects.Slow, (double c, double d, double m) => AllAlchemyEffects.Slow.Create(c, d, m)},
            {AllAlchemyEffects.Waterbreathing, (double c, double d, double m) => AllAlchemyEffects.Waterbreathing.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToFire, (double c, double d, double m) => AllAlchemyEffects.WeaknessToFire.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToFrost, (double c, double d, double m) => AllAlchemyEffects.WeaknessToFrost.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToShock, (double c, double d, double m) => AllAlchemyEffects.WeaknessToShock.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToMagic, (double c, double d, double m) => AllAlchemyEffects.WeaknessToMagic.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToPoison, (double c, double d, double m) => AllAlchemyEffects.WeaknessToPoison.Create(c, d, m)}
        };

        public IAlchemyEffect Create(IAlchemyEffect e, double cost, double duration, double magnitude) => map[e](cost, duration, magnitude);
    }
}