using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class RavageAttributeEffect : Effect
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
        public RavageAttributeEffect RavageHealth { get; } = new RavageAttributeEffect(Attribute.Health);

        public RavageAttributeEffect RavageMagicka { get; } = new RavageAttributeEffect(Attribute.Magicka);

        public RavageAttributeEffect RavageStamina { get; } = new RavageAttributeEffect(Attribute.Stamina);
    }
}