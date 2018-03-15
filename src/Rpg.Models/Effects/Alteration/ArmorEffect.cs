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
        public ArmorEffect Armor { get; } = new ArmorEffect();
    }
}