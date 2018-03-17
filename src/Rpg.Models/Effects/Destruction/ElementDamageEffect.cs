using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class ElementDamageEffect : Effect
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
        public ElementDamageEffect FireDamage { get; } = new ElementDamageEffect(Element.Fire);

        public ElementDamageEffect FrostDamage { get; } = new ElementDamageEffect(Element.Frost);

        public ElementDamageEffect ShockDamage { get; } = new ElementDamageEffect(Element.Shock);
    }
}