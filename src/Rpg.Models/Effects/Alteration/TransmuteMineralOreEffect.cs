namespace Rpg.Models.Effects.Alteration
{
    public class TransmuteMineralOreEffectEffect : Effect<TransmuteMineralOreEffectEffect>
    {
        public TransmuteMineralOreEffectEffect() 
            : base("Transmute Mineral Ore")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly TransmuteMineralOreEffectEffect TransmuteMineralOreEffect = new TransmuteMineralOreEffectEffect();
    }
}