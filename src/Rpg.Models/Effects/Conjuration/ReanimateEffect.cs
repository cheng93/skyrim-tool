namespace Rpg.Models.Effects.Conjuration
{
    public class ReanimateEffect : Effect<ReanimateEffect>
    {
        public ReanimateEffect() 
            : base("Reanimate")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public ReanimateEffect Reanimate { get; } = new ReanimateEffect();
    }
}