namespace Rpg.Models.Effects.Illusion
{
    public class FearEffect : Effect<FearEffect>
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