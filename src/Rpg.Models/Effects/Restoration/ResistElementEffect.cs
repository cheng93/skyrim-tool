using Rpg.Models.Common.Enums;

namespace Rpg.Models.Effects.Restoration
{
    public class ResistElementEffect : Effect
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
        public ResistElementEffect ResistFire { get; } = new ResistElementEffect(Element.Fire);

        public ResistElementEffect ResistFrost { get; } = new ResistElementEffect(Element.Frost);

        public ResistElementEffect ResistShock { get; } = new ResistElementEffect(Element.Shock);
    }
}