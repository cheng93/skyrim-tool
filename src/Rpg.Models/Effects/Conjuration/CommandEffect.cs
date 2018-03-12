namespace Rpg.Models.Effects.Conjuration
{
    public class CommandEffect : Effect<CommandEffect>
    {
        public CommandEffect() 
            : base("Command")
        {
        }
    }

    public partial class ConjurationEffects 
    {
        public static readonly CommandEffect Command = new CommandEffect();
    }
}