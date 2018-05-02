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
        public FortifyShoutEffect FortifyShout { get; } = new FortifyShoutEffect();
    }
}