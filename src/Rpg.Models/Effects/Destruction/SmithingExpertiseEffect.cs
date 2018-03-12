namespace Rpg.Models.Effects.Destruction
{
    public class SmithingExpertiseEffect : Effect
    {
        public SmithingExpertiseEffect() 
            : base("Smithing Expertise")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public static readonly SmithingExpertiseEffect SmithingExpertise = new SmithingExpertiseEffect();
    }
}