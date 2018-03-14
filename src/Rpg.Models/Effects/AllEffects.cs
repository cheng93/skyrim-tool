using Rpg.Models.Effects.Alteration;
using Rpg.Models.Effects.Conjuration;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Effects.Illusion;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Effects
{
    public static class AllEffects
    {
        public static readonly AlterationEffects Alteration = new AlterationEffects();

        public static readonly ConjurationEffects Conjuration = new ConjurationEffects();

        public static readonly DestructionEffects Destruction = new DestructionEffects();

        public static readonly IllusionEffects Illusion = new IllusionEffects();

        public static readonly RestorationEffects Restoration = new RestorationEffects();
    }
}