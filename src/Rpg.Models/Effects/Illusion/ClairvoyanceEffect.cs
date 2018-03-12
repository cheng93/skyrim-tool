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
        public static readonly ClairvoyanceEffect Clairvoyance = new ClairvoyanceEffect();
    }
}