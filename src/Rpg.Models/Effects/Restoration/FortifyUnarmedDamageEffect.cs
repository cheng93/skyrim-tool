namespace Rpg.Models.Effects.Restoration
{
    public class FortifyUnarmedDamageEffect : Effect
    {
        public FortifyUnarmedDamageEffect() 
            : base("Fortify Unarmed Damage")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public FortifyUnarmedDamageEffect FortifyUnarmedDamage { get; } = new FortifyUnarmedDamageEffect();
    }
}