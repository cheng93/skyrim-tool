using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Extensions
{
    public static class AlchemyEffectExtensions
    {
        private static List<IAlchemyEffect> durationAffects = new List<IAlchemyEffect>()
        {
            AllAlchemyEffects.Invisibility,
            AllAlchemyEffects.Paralyze,
            AllAlchemyEffects.Slow,
            AllAlchemyEffects.Waterbreathing
        };

        public static bool PowerAffectsDuration(this IAlchemyEffect e) => durationAffects.Contains(e);

        public static bool PowerAffectsMagnitude(this IAlchemyEffect e) => !durationAffects.Contains(e);
        
    }
}