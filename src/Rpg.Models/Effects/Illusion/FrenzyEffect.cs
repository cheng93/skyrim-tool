namespace Rpg.Models.Effects.Illusion
{
    public class FrenzyEffect : Effect
    {
        public FrenzyEffect() 
            : base("Frenzy")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public FrenzyEffect Frenzy { get; } = new FrenzyEffect();
    }
}