namespace Rpg.Models.Effects.Illusion
{
    public class InvisibilityEffect : Effect
    {
        public InvisibilityEffect() 
            : base("Invisibility")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public InvisibilityEffect Invisibility { get; } = new InvisibilityEffect();
    }
}