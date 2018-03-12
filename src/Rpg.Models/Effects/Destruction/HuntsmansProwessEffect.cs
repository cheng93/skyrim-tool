namespace Rpg.Models.Effects.Destruction
{
    public class HuntsmansProwessEffect : Effect
    {
        public HuntsmansProwessEffect() 
            : base("Huntsman's Prowess")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public static readonly HuntsmansProwessEffect HuntsmansProwess = new HuntsmansProwessEffect();
    }
}