namespace Rpg.Models.Effects.Restoration
{
    public class FortifyShoutEffect : Effect
    {
        public FortifyShoutEffect() 
            : base("Fortify Shout")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public static readonly FortifyShoutEffect FortifyShout = new FortifyShoutEffect();
    }
}