using Rpg.Models.Effects.Enums;

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
        public static readonly RestoreAttributeEffect RestoreHealth = new RestoreAttributeEffect(Attribute.Health);

        public static readonly RestoreAttributeEffect RestoreMagicka = new RestoreAttributeEffect(Attribute.Magicka);

        public static readonly RestoreAttributeEffect RestoreStamina = new RestoreAttributeEffect(Attribute.Stamina);
    }
}