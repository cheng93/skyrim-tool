namespace Rpg.Models.Effects.Conjuration
{
    public class BoundWeaponEffect : Effect
    {
        public BoundWeaponEffect() 
            : base("Bound Weapon")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public static readonly BoundWeaponEffect BoundWeapon = new BoundWeaponEffect();
    }
}