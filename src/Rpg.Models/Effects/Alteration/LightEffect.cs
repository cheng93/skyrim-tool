namespace Rpg.Models.Effects.Alteration
{
    public class LightEffect : Effect<LightEffect>
    {
        public LightEffect() 
            : base("Light")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly LightEffect Light = new LightEffect();
    }
}