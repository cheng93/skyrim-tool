using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Restoration
{
    public class ResistElementEffect : Effect<ResistElementEffect>
    {
        public ResistElementEffect(Element element)
            : base($"Resist {element.ToString()}")
        {
            Element = element;
        }

        public Element Element { get; }
    }

    public partial class RestorationEffects 
    {
        public static readonly ResistElementEffect ResistFire = new ResistElementEffect(Element.Fire);

        public static readonly ResistElementEffect ResistFrost = new ResistElementEffect(Element.Frost);

        public static readonly ResistElementEffect ResistShock = new ResistElementEffect(Element.Shock);
    }
}