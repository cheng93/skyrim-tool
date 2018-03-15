namespace Rpg.Models.Effects.Conjuration
{
    public class ConjureEffect : Effect<ConjureEffect>
    {
        public ConjureEffect() 
            : base("Conjure")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public ConjureEffect Conjure { get; } = new ConjureEffect();
    }
}