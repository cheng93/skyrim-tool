using Rpg.Models.Effects.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class AbsorbAttributeEffect : Effect<AbsorbAttributeEffect>
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
        public static readonly AbsorbAttributeEffect AbsorbHealth = new AbsorbAttributeEffect(Attribute.Health);

        public static readonly AbsorbAttributeEffect AbsorbMagicka = new AbsorbAttributeEffect(Attribute.Magicka);

        public static readonly AbsorbAttributeEffect AbsorbStamina = new AbsorbAttributeEffect(Attribute.Stamina);
    }
}