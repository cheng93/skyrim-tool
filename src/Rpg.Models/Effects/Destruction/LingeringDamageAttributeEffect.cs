using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class LingeringDamageAttributeEffect : Effect<LingeringDamageAttributeEffect>
    {
        public LingeringDamageAttributeEffect(Attribute attribute) 
            : base($"Lingering Damage {attribute.ToString()}")
        {
            Attribute = attribute;
        }

        public Attribute Attribute { get; }
    }

    public partial class DestructionEffects 
    {
        public LingeringDamageAttributeEffect LingeringDamageHealth { get; } = new LingeringDamageAttributeEffect(Attribute.Health);

        public LingeringDamageAttributeEffect LingeringDamageMagicka { get; } = new LingeringDamageAttributeEffect(Attribute.Magicka);

        public LingeringDamageAttributeEffect LingeringDamageStamina { get; } = new LingeringDamageAttributeEffect(Attribute.Stamina);
    }
}