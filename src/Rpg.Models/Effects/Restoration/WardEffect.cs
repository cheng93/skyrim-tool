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
        public static readonly WardEffect Ward = new WardEffect();
    }
}