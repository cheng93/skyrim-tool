using Rpg.Models.Effects.Alteration;
using Rpg.Models.Effects.Illusion;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Effects
{
    public static class Effects
    {
        public static readonly AlterationEffects Alteration = new AlterationEffects();

        public static readonly IllusionEffects Illusion = new IllusionEffects();

        public static readonly RestorationEffects Restoration = new RestorationEffects();
    }
}