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
        public static readonly RallyEffect Rally = new RallyEffect();
    }
}