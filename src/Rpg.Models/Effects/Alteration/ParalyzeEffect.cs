namespace Rpg.Models.Effects.Alteration
{
    public class ParalyzeEffect : Effect<ParalyzeEffect>
    {
        public ParalyzeEffect() 
            : base("Paralyze")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly ParalyzeEffect Paralyze = new ParalyzeEffect();
    }
}