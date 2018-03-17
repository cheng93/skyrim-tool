namespace Rpg.Models.Effects.Conjuration
{
    public class CommandEffect : Effect
    {
        public CommandEffect() 
            : base("Command")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public CommandEffect Command { get; } = new CommandEffect();
    }
}