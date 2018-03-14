using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Destruction
{
    public class WeaknessToElementEffect : Effect<WeaknessToElementEffect>
    {
        public WeaknessToElementEffect(Element element) 
            : base($"Weakness To {element}")
        {
            Element = element;
        }

        public Element Element { get; }
    }

    public partial class DestructionEffects 
    {
        public WeaknessToElementEffect WeaknessToFire { get; } = new WeaknessToElementEffect(Element.Fire);

        public WeaknessToElementEffect WeaknessToFrost { get; } = new WeaknessToElementEffect(Element.Frost);

        public WeaknessToElementEffect WeaknessToShock { get; } = new WeaknessToElementEffect(Element.Shock);
    }
}