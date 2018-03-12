namespace Rpg.Models.Effects.Destruction
{
    public class SpellAbsorptionEffect : Effect
    {
        public SpellAbsorptionEffect() 
            : base("Spell Absorption")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public static readonly SpellAbsorptionEffect SpellAbsorption = new SpellAbsorptionEffect();
    }
}