namespace Rpg.Models.Effects.Restoration
{
    public class ResistPoisonEffect : Effect<ResistPoisonEffect>
    {
        public ResistPoisonEffect()
            : base("Resist Poison")
        {
        }
    }

    public partial class RestorationEffects
    {
        public ResistPoisonEffect ResistPoison { get; } = new ResistPoisonEffect();
    }
}