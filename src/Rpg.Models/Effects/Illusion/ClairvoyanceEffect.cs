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
        public static readonly ClairvoyanceEffect Clairvoyance = new ClairvoyanceEffect();
    }
}