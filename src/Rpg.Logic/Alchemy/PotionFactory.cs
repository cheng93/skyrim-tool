using Rpg.Models.Alchemy;

namespace Rpg.Logic.Alchemy
{
    public interface IPotionFactory
    {
        IPotion Create(IAlchemyOptions options);
    }

    public class PotionFactory : IPotionFactory
    {
        public IPotion Create(IAlchemyOptions options)
        {
            throw new System.NotImplementedException();
        }
    }
}