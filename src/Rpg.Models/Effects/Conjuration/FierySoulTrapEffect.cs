namespace Rpg.Models.Effects.Conjuration
{
    public class FierySoulTrapEffect : Effect<FierySoulTrapEffect>
    {
        public FierySoulTrapEffect() 
            : base("Fiery Soul Trap")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public FierySoulTrapEffect FierySoulTrap { get; } = new FierySoulTrapEffect();
    }
}