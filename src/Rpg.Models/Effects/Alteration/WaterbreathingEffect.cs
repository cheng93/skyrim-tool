namespace Rpg.Models.Effects.Alteration
{
    public class WaterbreathingEffect : Effect<WaterbreathingEffect>
    {
        public WaterbreathingEffect() 
            : base("Waterbreathing")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly WaterbreathingEffect Waterbreathing = new WaterbreathingEffect();
    }
}