namespace Rpg.Models.Effects.Alteration
{
    public class ArmorEffect : Effect
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