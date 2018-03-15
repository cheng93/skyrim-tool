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
        public ParalyzeEffect Paralyze { get; } = new ParalyzeEffect();
    }
}