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
        public BoundWeaponEffect BoundWeapon { get; } = new BoundWeaponEffect();
    }
}