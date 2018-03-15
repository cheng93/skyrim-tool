namespace Rpg.Models.Effects.Destruction
{
    public class PoisonDamageEffect : Effect<PoisonDamageEffect>
    {
        public PoisonDamageEffect() 
            : base("Poison Damage")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public PoisonDamageEffect PoisonDamage { get; } = new PoisonDamageEffect();
    }
}