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
        public TurnUndeadEffect TurnUndead { get; } = new TurnUndeadEffect();
    }
}