namespace Rpg.Models.Effects.Illusion
{
    public class MuffleEffect : Effect
    {
        public MuffleEffect() 
            : base("Muffle")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public static readonly MuffleEffect Muffle = new MuffleEffect();
    }
}