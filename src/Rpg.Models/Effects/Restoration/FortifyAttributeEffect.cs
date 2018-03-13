using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Restoration
{
    public class FortifyAttributeEffect : Effect<FortifyAttributeEffect>
    {
        public FortifyAttributeEffect(Attribute attribute)
            : base($"Fortify {attribute.ToString()}")
        {
            Attribute = attribute;
        }

        public Attribute Attribute { get; }
    }

    public partial class RestorationEffects 
    {
        public static readonly FortifyAttributeEffect FortifyHealth = new FortifyAttributeEffect(Attribute.Health);

        public static readonly FortifyAttributeEffect FortifyMagicka = new FortifyAttributeEffect(Attribute.Magicka);

        public static readonly FortifyAttributeEffect FortifyStamina = new FortifyAttributeEffect(Attribute.Stamina);
    }
}