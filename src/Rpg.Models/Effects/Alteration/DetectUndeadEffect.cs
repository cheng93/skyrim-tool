namespace Rpg.Models.Effects.Alteration
{
    public class DetectUndeadEffect : Effect
    {
        public DetectUndeadEffect() 
            : base("Detect Undead")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly DetectUndeadEffect DetectUndead = new DetectUndeadEffect();
    }
}