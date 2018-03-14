namespace Rpg.Models.Effects.Alteration
{
    public class RuneEffect : Effect<RuneEffect>
    {
        public RuneEffect() 
            : base("Rune")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public RuneEffect Rune { get; } = new RuneEffect();
    }
}