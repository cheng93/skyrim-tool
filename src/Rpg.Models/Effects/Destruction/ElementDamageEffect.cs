using Rpg.Models.Effects.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class ElementDamageEffect : Effect<ElementDamageEffect>
    {
        public ElementDamageEffect(Element element) 
            : base($"{element} Damage")
        {
            Element = element;
        }

        public Element Element { get; }
    }

    public partial class DestructionEffects 
    {
        public static readonly ElementDamageEffect FireDamage = new ElementDamageEffect(Element.Fire);

        public static readonly ElementDamageEffect FrostDamage = new ElementDamageEffect(Element.Frost);

        public static readonly ElementDamageEffect ShockDamage = new ElementDamageEffect(Element.Shock);
    }
}