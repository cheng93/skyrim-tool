namespace Rpg.Models.Effects.Alteration
{
    public class DetectUndeadEffect : Effect<DetectUndeadEffect>
    {
        public DetectUndeadEffect() 
            : base("Detect Undead")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public DetectUndeadEffect DetectUndead { get; } = new DetectUndeadEffect();
    }
}