using Rpg.Logic.Alchemy.EffectIngredientPriorities;
using Rpg.Logic.Alchemy.Formulas;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Logic.Alchemy
{
    public interface IPotionBuilderFactory
    {
        IPotionBuilder Create();
    }

    public class PotionBuilderFactory : IPotionBuilderFactory
    {
        public IPotionBuilder Create()
        {
            return new PotionBuilder(
                new PotionFactory(
                    new EffectIngredientPriorityFactory(),
                    new AlchemyFormulae(),
                    new AlchemyEffectFactory()
                ),
                new AlchemyOptionsValidatorWrapper(
                    new AlchemyOptionsValidator()
                )
            );
        }
    }
}