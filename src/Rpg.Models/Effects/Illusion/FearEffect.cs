namespace Rpg.Models.Effects.Illusion
{
    public class FearEffect : Effect
    {
        public FearEffect() 
            : base("Fear")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public FearEffect Fear { get; } = new FearEffect();
    }
}