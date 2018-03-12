using Rpg.Models.Effects.Enums;

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
        public static readonly WeaknessToElementEffect WeaknessToFire = new WeaknessToElementEffect(Element.Fire);

        public static readonly WeaknessToElementEffect WeaknessToFrost = new WeaknessToElementEffect(Element.Frost);

        public static readonly WeaknessToElementEffect WeaknessToShock = new WeaknessToElementEffect(Element.Shock);
    }
}