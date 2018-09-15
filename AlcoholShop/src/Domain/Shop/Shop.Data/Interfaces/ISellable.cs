using Shop.Data.BusinessModels;

namespace Shop.Data.Interfaces
{
    public interface ISellable
    {
        void Sell(Good goodToSell);
    }
}
