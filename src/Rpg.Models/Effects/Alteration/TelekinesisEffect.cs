namespace Rpg.Models.Effects.Alteration
{
    public class TelekinesisEffect : Effect
    {
        public TelekinesisEffect() 
            : base("Telekinesis")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public TelekinesisEffect Telekinesis { get; } = new TelekinesisEffect();
    }
}