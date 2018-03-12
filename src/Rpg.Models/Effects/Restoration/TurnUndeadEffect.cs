namespace Rpg.Models.Effects.Restoration
{
    public class TurnUndeadEffect : Effect<TurnUndeadEffect>
    {
        public TurnUndeadEffect() 
            : base("Turn Undead")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public static readonly TurnUndeadEffect TurnUndead = new TurnUndeadEffect();
    }
}