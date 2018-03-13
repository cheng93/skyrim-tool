using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class DamageAttributeEffect : Effect<DamageAttributeEffect>
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
        public static readonly DamageAttributeEffect DamageHealth = new DamageAttributeEffect(Attribute.Health);

        public static readonly DamageAttributeEffect DamageMagicka = new DamageAttributeEffect(Attribute.Magicka);

        public static readonly DamageAttributeEffect DamageStamina = new DamageAttributeEffect(Attribute.Stamina);
    }
}