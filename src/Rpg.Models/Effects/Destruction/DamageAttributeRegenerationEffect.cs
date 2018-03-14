using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class DamageAttributeRegenerationEffect : Effect<DamageAttributeRegenerationEffect>
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
        public DamageAttributeRegenerationEffect DamageHealthRegeneration { get; } = new DamageAttributeRegenerationEffect(Attribute.Health);

        public DamageAttributeRegenerationEffect DamageMagickaRegeneration { get; } = new DamageAttributeRegenerationEffect(Attribute.Magicka);

        public DamageAttributeRegenerationEffect DamageStaminaRegeneration { get; } = new DamageAttributeRegenerationEffect(Attribute.Stamina);
    }
}