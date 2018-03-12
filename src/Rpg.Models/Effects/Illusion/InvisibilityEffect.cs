namespace Rpg.Models.Effects.Illusion
{
    public class InvisibilityEffect : Effect<InvisibilityEffect>
    {
        public InvisibilityEffect() 
            : base("Invisibility")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public static readonly InvisibilityEffect Invisibility = new InvisibilityEffect();
    }
}