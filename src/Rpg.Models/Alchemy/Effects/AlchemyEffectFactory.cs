using System;
using System.Collections.Generic;
using Rpg.Models.Common;

namespace Rpg.Models.Alchemy.Effects
{
    public interface IAlchemyEffectFactory
    {
        IAlchemyEffect Create(IAlchemyEffect e, decimal cost, decimal duration, decimal magnitude);
    }

    public class AlchemyEffectFactory : IAlchemyEffectFactory
    {
        private static readonly Dictionary<IAlchemyEffect, Func<decimal, decimal, decimal, IAlchemyEffect>> map
            = new Dictionary<IAlchemyEffect, Func<decimal, decimal, decimal, IAlchemyEffect>>(new IHasIdEqualityComparer())
        {
            {AllAlchemyEffects.CureDisease, (decimal c, decimal d, decimal m) => AllAlchemyEffects.CureDisease.Create(c, d, m)},
            {AllAlchemyEffects.DamageHealth, (decimal c, decimal d, decimal m) => AllAlchemyEffects.DamageHealth.Create(c, d, m)},
            {AllAlchemyEffects.DamageMagicka, (decimal c, decimal d, decimal m) => AllAlchemyEffects.DamageMagicka.Create(c, d, m)},
            {AllAlchemyEffects.DamageStamina, (decimal c, decimal d, decimal m) => AllAlchemyEffects.DamageStamina.Create(c, d, m)},
            {AllAlchemyEffects.DamageMagickaRegeneration, (decimal c, decimal d, decimal m) => AllAlchemyEffects.DamageMagickaRegeneration.Create(c, d, m)},
            {AllAlchemyEffects.DamageStaminaRegeneration, (decimal c, decimal d, decimal m) => AllAlchemyEffects.DamageStaminaRegeneration.Create(c, d, m)},
            {AllAlchemyEffects.Fear, (decimal c, decimal d, decimal m) => AllAlchemyEffects.Fear.Create(c, d, m)},
            {AllAlchemyEffects.FortifyHealth, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyHealth.Create(c, d, m)},
            {AllAlchemyEffects.FortifyMagicka, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyMagicka.Create(c, d, m)},
            {AllAlchemyEffects.FortifyStamina, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyStamina.Create(c, d, m)},
            {AllAlchemyEffects.FortifyCarryWeight, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyCarryWeight.Create(c, d, m)},
            {AllAlchemyEffects.FortifyAlteration, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyAlteration.Create(c, d, m)},
            {AllAlchemyEffects.FortifyArchery, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyArchery.Create(c, d, m)},
            {AllAlchemyEffects.FortifyBarter, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyBarter.Create(c, d, m)},
            {AllAlchemyEffects.FortifyBlock, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyBlock.Create(c, d, m)},
            {AllAlchemyEffects.FortifyConjuration, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyConjuration.Create(c, d, m)},
            {AllAlchemyEffects.FortifyDestruction, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyDestruction.Create(c, d, m)},
            {AllAlchemyEffects.FortifyEnchanting, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyEnchanting.Create(c, d, m)},
            {AllAlchemyEffects.FortifyHeavyArmor, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyHeavyArmor.Create(c, d, m)},
            {AllAlchemyEffects.FortifyIllusion, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyIllusion.Create(c, d, m)},
            {AllAlchemyEffects.FortifyLightArmor, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyLightArmor.Create(c, d, m)},
            {AllAlchemyEffects.FortifyLockpicking, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyLockpicking.Create(c, d, m)},
            {AllAlchemyEffects.FortifyOneHanded, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyOneHanded.Create(c, d, m)},
            {AllAlchemyEffects.FortifyPickpocket, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyPickpocket.Create(c, d, m)},
            {AllAlchemyEffects.FortifyRestoration, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyRestoration.Create(c, d, m)},
            {AllAlchemyEffects.FortifySmithing, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifySmithing.Create(c, d, m)},
            {AllAlchemyEffects.FortifySneak, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifySneak.Create(c, d, m)},
            {AllAlchemyEffects.FortifyTwoHanded, (decimal c, decimal d, decimal m) => AllAlchemyEffects.FortifyTwoHanded.Create(c, d, m)},
            {AllAlchemyEffects.Frenzy, (decimal c, decimal d, decimal m) => AllAlchemyEffects.Frenzy.Create(c, d, m)},
            {AllAlchemyEffects.Invisibility, (decimal c, decimal d, decimal m) => AllAlchemyEffects.Invisibility.Create(c, d, m)},
            {AllAlchemyEffects.LingeringDamageHealth, (decimal c, decimal d, decimal m) => AllAlchemyEffects.LingeringDamageHealth.Create(c, d, m)},
            {AllAlchemyEffects.LingeringDamageMagicka, (decimal c, decimal d, decimal m) => AllAlchemyEffects.LingeringDamageMagicka.Create(c, d, m)},
            {AllAlchemyEffects.LingeringDamageStamina, (decimal c, decimal d, decimal m) => AllAlchemyEffects.LingeringDamageStamina.Create(c, d, m)},
            {AllAlchemyEffects.Paralyze, (decimal c, decimal d, decimal m) => AllAlchemyEffects.Paralyze.Create(c, d, m)},
            {AllAlchemyEffects.RavageHealth, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RavageHealth.Create(c, d, m)},
            {AllAlchemyEffects.RavageMagicka, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RavageMagicka.Create(c, d, m)},
            {AllAlchemyEffects.RavageStamina, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RavageStamina.Create(c, d, m)},
            {AllAlchemyEffects.RegenerateHealth, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RegenerateHealth.Create(c, d, m)},
            {AllAlchemyEffects.RegenerateMagicka, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RegenerateMagicka.Create(c, d, m)},
            {AllAlchemyEffects.RegenerateStamina, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RegenerateStamina.Create(c, d, m)},
            {AllAlchemyEffects.ResistFire, (decimal c, decimal d, decimal m) => AllAlchemyEffects.ResistFire.Create(c, d, m)},
            {AllAlchemyEffects.ResistFrost, (decimal c, decimal d, decimal m) => AllAlchemyEffects.ResistFrost.Create(c, d, m)},
            {AllAlchemyEffects.ResistShock, (decimal c, decimal d, decimal m) => AllAlchemyEffects.ResistShock.Create(c, d, m)},
            {AllAlchemyEffects.ResistMagic, (decimal c, decimal d, decimal m) => AllAlchemyEffects.ResistMagic.Create(c, d, m)},
            {AllAlchemyEffects.ResistPoison, (decimal c, decimal d, decimal m) => AllAlchemyEffects.ResistPoison.Create(c, d, m)},
            {AllAlchemyEffects.RestoreHealth, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RestoreHealth.Create(c, d, m)},
            {AllAlchemyEffects.RestoreMagicka, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RestoreMagicka.Create(c, d, m)},
            {AllAlchemyEffects.RestoreStamina, (decimal c, decimal d, decimal m) => AllAlchemyEffects.RestoreStamina.Create(c, d, m)},
            {AllAlchemyEffects.Slow, (decimal c, decimal d, decimal m) => AllAlchemyEffects.Slow.Create(c, d, m)},
            {AllAlchemyEffects.Waterbreathing, (decimal c, decimal d, decimal m) => AllAlchemyEffects.Waterbreathing.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToFire, (decimal c, decimal d, decimal m) => AllAlchemyEffects.WeaknessToFire.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToFrost, (decimal c, decimal d, decimal m) => AllAlchemyEffects.WeaknessToFrost.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToShock, (decimal c, decimal d, decimal m) => AllAlchemyEffects.WeaknessToShock.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToMagic, (decimal c, decimal d, decimal m) => AllAlchemyEffects.WeaknessToMagic.Create(c, d, m)},
            {AllAlchemyEffects.WeaknessToPoison, (decimal c, decimal d, decimal m) => AllAlchemyEffects.WeaknessToPoison.Create(c, d, m)}
        };

        public IAlchemyEffect Create(IAlchemyEffect e, decimal cost, decimal duration, decimal magnitude) => map[e](cost, duration, magnitude);
    }
}