namespace Rpg.Models.Effects.Alteration
{
    public class RuneEffect : Effect
    {
        public RuneEffect() 
            : base("Rune")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly RuneEffect Rune = new RuneEffect();
    }
}