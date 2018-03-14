namespace Rpg.Models.Effects.Restoration
{
    public class RuneEffect : Effect<RuneEffect>
    {
        public RuneEffect() 
            : base("Rune")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public RuneEffect Rune { get; } = new RuneEffect();
    }
}