namespace Rpg.Models.Effects.Destruction
{
    public class RuneEffect : Effect
    {
        public RuneEffect() 
            : base("Rune")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public RuneEffect Rune { get; } = new RuneEffect();
    }
}