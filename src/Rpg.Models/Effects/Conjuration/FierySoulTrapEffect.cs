namespace Rpg.Models.Effects.Conjuration
{
    public class FierySoulTrapEffect : Effect
    {
        public FierySoulTrapEffect() 
            : base("Fiery Soul Trap")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public static readonly FierySoulTrapEffect FierySoulTrap = new FierySoulTrapEffect();
    }
}