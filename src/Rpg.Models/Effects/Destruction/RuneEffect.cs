namespace Rpg.Models.Effects.Destruction
{
    public class RuneEffect : Effect<RuneEffect>
    {
        public RuneEffect() 
            : base("Rune")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public static readonly RuneEffect Rune = new RuneEffect();
    }
}