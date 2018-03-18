namespace Rpg.Models.Effects.Destruction
{
    public class BriarheartGeisEffect : Effect
    {
        public BriarheartGeisEffect() 
            : base("Briarheart Geis")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public BriarheartGeisEffect BriarheartGeis { get; } = new BriarheartGeisEffect();
    }
}