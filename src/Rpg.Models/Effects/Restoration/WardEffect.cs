namespace Rpg.Models.Effects.Restoration
{
    public class WardEffect : Effect
    {
        public WardEffect() 
            : base("Ward")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public WardEffect Ward { get; } = new WardEffect();
    }
}