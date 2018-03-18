using System.Collections.Generic;
using System.Linq;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Perks;
using Rpg.Models.Perks.Alchemy;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy.Formulas
{
    internal static class PerksFormulae
    {
        public static double GetPerks(IAlchemyEffect effect, IEnumerable<IPerk<AlchemySkill>> perks)
        {
            var alchemistPerkFactor = GetAlchemistPerkFactor(perks);
            var physicianPerkFactor = GetPhysicianPerkFactor(effect, perks);
            var benefactorPerkFactor = GetBenefactorPerkFactor(effect, perks);
            var poisonerPerkFactor = GetPoisonerPerkFactor(effect, perks);

            return (1 + alchemistPerkFactor / 100)
                * (1 + physicianPerkFactor / 100)
                * (1 + benefactorPerkFactor / 100 + poisonerPerkFactor / 100);
        }

        private static double GetAlchemistPerkFactor(IEnumerable<IPerk<AlchemySkill>> perks)
        {
            return perks
                .OfType<AlchemistPerk>()
                .SingleOrDefault()
                ?.Rank * 20
                ?? 0;
        }

        private static double GetPhysicianPerkFactor(IAlchemyEffect effect, IEnumerable<IPerk<AlchemySkill>> perks)
        {
            var hasPhysicianPerk = perks.OfType<PhysicianPerk>().Any();
            var isRestoreAttributeEffect = new []
            {
                AllAlchemyEffects.RestoreHealth,
                AllAlchemyEffects.RestoreMagicka,
                AllAlchemyEffects.RestoreStamina
            }.Contains(effect);

            return hasPhysicianPerk && isRestoreAttributeEffect
                ? 25
                : 0;
        }

        private static double GetBenefactorPerkFactor(IAlchemyEffect effect, IEnumerable<IPerk<AlchemySkill>> perks)
        {
            var hasBenefactorPerk = perks.OfType<BenefactorPerk>().Any();

            return hasBenefactorPerk && effect.IsPositiveEffect
                ? 25
                : 0;
        }

        private static double GetPoisonerPerkFactor(IAlchemyEffect effect, IEnumerable<IPerk<AlchemySkill>> perks)
        {
            var hasPoisonerPerk = perks.OfType<PoisonerPerk>().Any();

            return hasPoisonerPerk && !effect.IsPositiveEffect
                ? 25
                : 0;
        }
    }
}