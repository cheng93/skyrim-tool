namespace Rpg.Models.Effects.Alteration
{
    public class ArmorEffect : Effect<ArmorEffect>
    {
        public ArmorEffect() 
            : base("Armor")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public static readonly ArmorEffect Armor = new ArmorEffect();
    }
}