using MikroservisStock.Basket.Dtos;

namespace MikroservisStock.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasket(string userId);
        Task SaveOrUpdateBasket(BasketTotalDto basketTotalDto);
        Task DeleteBasket(string userId);
    }
}
