namespace Rpg.Models.Effects.Restoration
{
    public class CurePoisonEffect : Effect
    {
        public CurePoisonEffect() 
            : base("Cure Poison")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public CurePoisonEffect CurePoison { get; } = new CurePoisonEffect();
    }
}