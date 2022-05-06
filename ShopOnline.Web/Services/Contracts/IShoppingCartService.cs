using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts
{
    public interface IShoppingCartService
    {
        Task<IEnumerable<CartItemDtos>> GetItems(int userId);
        Task<CartItemDtos> AddItem(CartItemToAddDto cartItemToAddDto);
    }
}
