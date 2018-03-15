namespace Rpg.Models.Effects.Illusion
{
    public class MuffleEffect : Effect<MuffleEffect>
    {
        public MuffleEffect() 
            : base("Muffle")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public MuffleEffect Muffle { get; } = new MuffleEffect();
    }
}