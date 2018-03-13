using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class RavageAttributeEffect : Effect<RavageAttributeEffect>
    {
        public RavageAttributeEffect(Attribute attribute) 
            : base($"Ravage {attribute.ToString()}")
        {
            Attribute = attribute;
        }

        public Attribute Attribute { get; }
    }

    public partial class DestructionEffects 
    {
        public static readonly RavageAttributeEffect RavageHealth = new RavageAttributeEffect(Attribute.Health);

        public static readonly RavageAttributeEffect RavageMagicka = new RavageAttributeEffect(Attribute.Magicka);

        public static readonly RavageAttributeEffect RavageStamina = new RavageAttributeEffect(Attribute.Stamina);
    }
}