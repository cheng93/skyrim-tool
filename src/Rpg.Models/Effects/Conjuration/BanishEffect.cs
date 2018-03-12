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
        public static readonly BanishEffect Banish = new BanishEffect();
    }
}