using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Restoration
{
    public class FortifyAttributeEffect : Effect
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
        public FortifyAttributeEffect FortifyHealth { get; } = new FortifyAttributeEffect(Attribute.Health);

        public FortifyAttributeEffect FortifyMagicka { get; } = new FortifyAttributeEffect(Attribute.Magicka);

        public FortifyAttributeEffect FortifyStamina { get; } = new FortifyAttributeEffect(Attribute.Stamina);
    }
}