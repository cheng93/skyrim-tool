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
        public SmithingExpertiseEffect SmithingExpertise { get; } = new SmithingExpertiseEffect();
    }
}