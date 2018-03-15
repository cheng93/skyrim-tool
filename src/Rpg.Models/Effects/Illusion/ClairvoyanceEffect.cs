namespace Rpg.Models.Effects.Illusion
{
    public class ClairvoyanceEffect : Effect<ClairvoyanceEffect>
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