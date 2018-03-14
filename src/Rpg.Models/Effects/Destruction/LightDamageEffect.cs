namespace Rpg.Models.Effects.Destruction
{
    public class LightDamageEffect : Effect<LightDamageEffect>
    {
        public LightDamageEffect() 
            : base("Light Damage")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public LightDamageEffect LightDamage { get; } = new LightDamageEffect();
    }
}