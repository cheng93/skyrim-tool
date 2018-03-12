namespace Rpg.Models.Effects.Alteration
{
    public class DetectLifeEffect : Effect<DetectLifeEffect>
    {
        public DetectLifeEffect() 
            : base("Detect Life")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly DetectLifeEffect DetectLife = new DetectLifeEffect();
    }
}