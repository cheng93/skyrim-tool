using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Restoration
{
    public class RegenerateAttributeEffect : Effect
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
        public RegenerateAttributeEffect RegenerateHealth { get; } = new RegenerateAttributeEffect(Attribute.Health);

        public RegenerateAttributeEffect RegenerateMagicka { get; } = new RegenerateAttributeEffect(Attribute.Magicka);

        public RegenerateAttributeEffect RegenerateStamina { get; } = new RegenerateAttributeEffect(Attribute.Stamina);
    }
}