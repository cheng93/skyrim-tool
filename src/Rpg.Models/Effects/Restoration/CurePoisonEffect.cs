namespace Rpg.Models.Effects.Restoration
{
    public class CurePoisonEffect : Effect<CurePoisonEffect>
    {
        public CurePoisonEffect() 
            : base("Cure Poison")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public static readonly CurePoisonEffect CurePoison = new CurePoisonEffect();
    }
}