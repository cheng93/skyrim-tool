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
                new PotionFactory(),
                new AlchemyOptionsValidatorWrapper(
                    new AlchemyOptionsValidator()
                )
            );
        }
    }
}