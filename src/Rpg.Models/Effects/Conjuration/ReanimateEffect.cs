namespace Rpg.Models.Effects.Conjuration
{
    public class ReanimateEffect : Effect
    {
        public ReanimateEffect() 
            : base("Reanimate")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public static readonly ReanimateEffect Reanimate = new ReanimateEffect();
    }
}