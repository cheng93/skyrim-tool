namespace Rpg.Models.Effects.Destruction
{
    public class WeaknessToMagicEffect : Effect
    {
        public WeaknessToMagicEffect() 
            : base("Weakness To Magic")
        {
        }
    }

    public partial class DestructionEffects 
    {
        public static readonly WeaknessToMagicEffect WeaknessToMagic = new WeaknessToMagicEffect();
    }
}