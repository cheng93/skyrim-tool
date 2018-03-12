namespace Rpg.Models.Effects.Destruction
{
    public class SpellAbsorptionEffect : Effect<SpellAbsorptionEffect>
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