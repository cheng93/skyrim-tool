namespace Rpg.Models.Effects.Alteration
{
    public class TelekinesisEffect : Effect<TelekinesisEffect>
    {
        public TelekinesisEffect() 
            : base("Telekinesis")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly TelekinesisEffect Telekinesis = new TelekinesisEffect();
    }
}