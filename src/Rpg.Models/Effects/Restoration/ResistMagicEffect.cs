namespace Rpg.Models.Effects.Restoration
{
    public class ResistMagicEffect : Effect<ResistMagicEffect>
    {
        public ResistMagicEffect()
            : base("Resist Magic")
        {
        }
    }

    public partial class RestorationEffects
    {
        public static readonly ResistMagicEffect ResistMagic = new ResistMagicEffect();
    }
}