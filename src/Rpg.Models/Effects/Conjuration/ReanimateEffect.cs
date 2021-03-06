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
        public ReanimateEffect Reanimate { get; } = new ReanimateEffect();
    }
}