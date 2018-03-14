namespace Rpg.Models.Effects.Restoration
{
    public class FortifySpellEffect : Effect<FortifySpellEffect>
    {
        public FortifySpellEffect() 
            : base("Fortify Spell")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public FortifySpellEffect FortifySpell { get; } = new FortifySpellEffect();
    }
}