using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class DamageAttributeEffect : Effect
    {
        public DamageAttributeEffect(Attribute attribute) 
            : base($"Damage {attribute.ToString()}")
        {
            Attribute = attribute;
        }

        public Attribute Attribute { get; }
    }

    public partial class DestructionEffects 
    {
        public DamageAttributeEffect DamageHealth { get; } = new DamageAttributeEffect(Attribute.Health);

        public DamageAttributeEffect DamageMagicka { get; } = new DamageAttributeEffect(Attribute.Magicka);

        public DamageAttributeEffect DamageStamina { get; } = new DamageAttributeEffect(Attribute.Stamina);
    }
}