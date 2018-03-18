namespace Rpg.Models.Effects.Destruction
{
    public class LightDamageEffect : Effect
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