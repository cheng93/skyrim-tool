namespace Rpg.Models.Effects.Destruction
{
    public class WeaknessToPoisonEffect : Effect
    {
        public WeaknessToPoisonEffect() 
            : base("Weakness To Poison")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public WeaknessToPoisonEffect WeaknessToPoison { get; } = new WeaknessToPoisonEffect();
    }
}