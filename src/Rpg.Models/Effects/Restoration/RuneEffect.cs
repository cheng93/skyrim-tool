namespace Rpg.Models.Effects.Restoration
{
    public class RuneEffect : Effect
    {
        public RuneEffect() 
            : base("Rune")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public static readonly RuneEffect Rune = new RuneEffect();
    }
}