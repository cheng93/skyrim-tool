namespace Rpg.Models.Effects.Illusion
{
    public class RuneEffect : Effect
    {
        public RuneEffect() 
            : base("Rune")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public static readonly RuneEffect Rune = new RuneEffect();
    }
}