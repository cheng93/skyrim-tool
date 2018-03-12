using Rpg.Models.Effects.Enums;

namespace Rpg.Models.Effects.Restoration
{
    public class RegenerateAttributeEffect : Effect<RegenerateAttributeEffect>
    {
        public RegenerateAttributeEffect(Attribute attribute)
            : base($"Regenerate {attribute.ToString()}")
        {
            Attribute = attribute;
        }

        public Attribute Attribute { get; }
    }

    public partial class RestorationEffects 
    {
        public static readonly RegenerateAttributeEffect RegenerateHealth = new RegenerateAttributeEffect(Attribute.Health);

        public static readonly RegenerateAttributeEffect RegenerateMagicka = new RegenerateAttributeEffect(Attribute.Magicka);

        public static readonly RegenerateAttributeEffect RegenerateStamina = new RegenerateAttributeEffect(Attribute.Stamina);
    }
}