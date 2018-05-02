namespace Rpg.Models.Effects.Alteration
{
    public class TransmuteMineralOreEffectEffect : Effect
    {
        public TransmuteMineralOreEffectEffect() 
            : base("Transmute Mineral Ore")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public TransmuteMineralOreEffectEffect TransmuteMineralOreEffect { get; } = new TransmuteMineralOreEffectEffect();
    }
}