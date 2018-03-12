namespace Rpg.Models.Effects.Conjuration
{
    public class SoulTrapEffect : Effect<SoulTrapEffect>
    {
        public SoulTrapEffect() 
            : base("Soul Trap")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public static readonly SoulTrapEffect SoulTrap = new SoulTrapEffect();
    }
}