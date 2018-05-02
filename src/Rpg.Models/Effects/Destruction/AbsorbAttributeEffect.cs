using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class AbsorbAttributeEffect : Effect
    {
        public AbsorbAttributeEffect(Attribute attribute) 
            : base($"Absorb {attribute.ToString()}")
        {
            Attribute = attribute;
        }

        public Attribute Attribute { get; }
    }

    public partial class DestructionEffects 
    {
        public AbsorbAttributeEffect AbsorbHealth { get; } = new AbsorbAttributeEffect(Attribute.Health);

        public AbsorbAttributeEffect AbsorbMagicka { get; } = new AbsorbAttributeEffect(Attribute.Magicka);

        public AbsorbAttributeEffect AbsorbStamina { get; } = new AbsorbAttributeEffect(Attribute.Stamina);
    }
}