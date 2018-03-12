namespace Rpg.Models.Effects.Restoration
{
    public class FortifyUnarmedDamageEffect : Effect<FortifyUnarmedDamageEffect>
    {
        public FortifyUnarmedDamageEffect() 
            : base("Fortify Unarmed Damage")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public static readonly FortifyUnarmedDamageEffect FortifyUnarmedDamage = new FortifyUnarmedDamageEffect();
    }
}