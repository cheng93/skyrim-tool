namespace Rpg.Models.Effects.Destruction
{
    public class HuntsmansProwessEffect : Effect<HuntsmansProwessEffect>
    {
        public HuntsmansProwessEffect() 
            : base("Huntsman's Prowess")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public HuntsmansProwessEffect HuntsmansProwess { get; } = new HuntsmansProwessEffect();
    }
}