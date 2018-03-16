using Rpg.Models.Alchemy;

namespace Rpg.Logic.Alchemy
{
    internal interface IPotionFactory
    {
        IPotion Create(IAlchemyOptions options);
    }

    internal class PotionFactory : IPotionFactory
    {
        public IPotion Create(IAlchemyOptions options)
        {
            throw new System.NotImplementedException();
        }
    }
}