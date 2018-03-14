namespace Rpg.Models.Effects.Destruction
{
    public class WeaknessToMagicEffect : Effect<WeaknessToMagicEffect>
    {
        public WeaknessToMagicEffect() 
            : base("Weakness To Magic")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public WeaknessToMagicEffect WeaknessToMagic { get; } = new WeaknessToMagicEffect();
    }
}