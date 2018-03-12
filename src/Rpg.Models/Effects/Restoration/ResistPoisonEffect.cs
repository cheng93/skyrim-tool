namespace Rpg.Models.Effects.Restoration
{
    public class ResistPoisonEffect : Effect
    {
        public ResistPoisonEffect()
            : base("Resist Poison")
        {
        }
    }

    public partial class RestorationEffects
    {
        public static readonly ResistPoisonEffect ResistPoison = new ResistPoisonEffect();
    }
}