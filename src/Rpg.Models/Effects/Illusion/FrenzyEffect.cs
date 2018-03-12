namespace Rpg.Models.Effects.Illusion
{
    public class FrenzyEffect : Effect<FrenzyEffect>
    {
        public FrenzyEffect() 
            : base("Frenzy")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public static readonly FrenzyEffect Frenzy = new FrenzyEffect();
    }
}