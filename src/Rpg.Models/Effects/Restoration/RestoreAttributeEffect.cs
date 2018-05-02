using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Restoration
{
    public class RestoreAttributeEffect : Effect
    {
        public RestoreAttributeEffect(Attribute attribute) 
            : base($"Restore {attribute.ToString()}")
        {
            Attribute = attribute;
        }

        public Attribute Attribute { get; }
    }

    public partial class RestorationEffects 
    {
        public RestoreAttributeEffect RestoreHealth { get; } = new RestoreAttributeEffect(Attribute.Health);

        public RestoreAttributeEffect RestoreMagicka { get; } = new RestoreAttributeEffect(Attribute.Magicka);

        public RestoreAttributeEffect RestoreStamina { get; } = new RestoreAttributeEffect(Attribute.Stamina);
    }
}