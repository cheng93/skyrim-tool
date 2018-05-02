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
        public TurnUndeadEffect TurnUndead { get; } = new TurnUndeadEffect();
    }
}