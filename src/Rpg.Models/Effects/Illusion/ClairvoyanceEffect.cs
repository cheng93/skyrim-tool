namespace Rpg.Models.Effects.Illusion
{
    public class ClairvoyanceEffect : Effect
    {
        public ClairvoyanceEffect() 
            : base("Clairvoyance")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public ClairvoyanceEffect Clairvoyance { get; } = new ClairvoyanceEffect();
    }
}