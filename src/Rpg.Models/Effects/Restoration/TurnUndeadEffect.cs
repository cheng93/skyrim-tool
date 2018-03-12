namespace Rpg.Models.Effects.Restoration
{
    public class TurnUndeadEffect : Effect
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