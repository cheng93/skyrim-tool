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
        public static readonly LingeringDamageAttributeEffect LingeringDamageHealth = new LingeringDamageAttributeEffect(Attribute.Health);

        public static readonly LingeringDamageAttributeEffect LingeringDamageMagicka = new LingeringDamageAttributeEffect(Attribute.Magicka);

        public static readonly LingeringDamageAttributeEffect LingeringDamageStamina = new LingeringDamageAttributeEffect(Attribute.Stamina);
    }
}