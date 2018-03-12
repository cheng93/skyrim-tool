namespace Rpg.Models.Effects.Destruction
{
    public class SlowEffect : Effect
    {
        public SlowEffect() 
            : base("Slow")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public static readonly SlowEffect Slow = new SlowEffect();
    }
}