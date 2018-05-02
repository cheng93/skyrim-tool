namespace Rpg.Models.Effects.Conjuration
{
    public class SoulTrapEffect : Effect
    {
        public SoulTrapEffect() 
            : base("Soul Trap")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public SoulTrapEffect SoulTrap { get; } = new SoulTrapEffect();
    }
}