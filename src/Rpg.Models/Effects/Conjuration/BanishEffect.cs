namespace Rpg.Models.Effects.Conjuration
{
    public class BanishEffect : Effect
    {
        public BanishEffect() 
            : base("Banish")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public BanishEffect Banish { get; } = new BanishEffect();
    }
}