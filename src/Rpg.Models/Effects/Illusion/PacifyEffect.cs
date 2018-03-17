namespace Rpg.Models.Effects.Illusion
{
    public class PacifyEffect : Effect
    {
        public PacifyEffect() 
            : base("Pacify")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public PacifyEffect Pacify { get; } = new PacifyEffect();
    }
}