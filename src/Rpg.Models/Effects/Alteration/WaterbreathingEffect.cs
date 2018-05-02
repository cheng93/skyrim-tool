namespace Rpg.Models.Effects.Alteration
{
    public class WaterbreathingEffect : Effect
    {
        public WaterbreathingEffect() 
            : base("Waterbreathing")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public WaterbreathingEffect Waterbreathing { get; } = new WaterbreathingEffect();
    }
}