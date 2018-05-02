namespace Rpg.Models.Effects.Alteration
{
    public class LightEffect : Effect
    {
        public LightEffect() 
            : base("Light")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public LightEffect Light { get; } = new LightEffect();
    }
}