using Rpg.Models.Effects.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class DamageAttributeRegenerationEffect : Effect
    {
        public DamageAttributeRegenerationEffect(Attribute attribute) 
            : base($"Damage {attribute.ToString()} Regeneration")
        {
            Attribute = attribute;
        }

        public Attribute Attribute { get; }
    }

    public partial class DestructionEffects 
    {
        public static readonly DamageAttributeRegenerationEffect DamageHealthRegeneration = new DamageAttributeRegenerationEffect(Attribute.Health);

        public static readonly DamageAttributeRegenerationEffect DamageMagickaRegeneration = new DamageAttributeRegenerationEffect(Attribute.Magicka);

        public static readonly DamageAttributeRegenerationEffect DamageStaminaRegeneration = new DamageAttributeRegenerationEffect(Attribute.Stamina);
    }
}