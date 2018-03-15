namespace Rpg.Models.Effects.Illusion
{
    public class RallyEffect : Effect<RallyEffect>
    {
        public RallyEffect() 
            : base("Rally")
        {
        }
    }

    public partial class IllusionEffects 
    {
        public RallyEffect Rally { get; } = new RallyEffect();
    }
}