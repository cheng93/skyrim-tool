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
        public static readonly BriarheartGeisEffect BriarheartGeis = new BriarheartGeisEffect();
    }
}