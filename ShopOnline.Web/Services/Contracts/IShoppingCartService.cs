﻿using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts
{
    public interface IShoppingCartService
    {
        Task<List<CartItemDtos>> GetItems(int userId);
        Task<CartItemDtos> AddItem(CartItemToAddDto cartItemToAddDto);
        Task<CartItemDtos> DeleteItem(int id);
        Task<CartItemDtos> UpdateItem(CartItemQtyUpdateDto cartItemQtyUpdateDto);

        event Action<int> OnShoppingCartChanged;
        void RaiseEventOnShoppingCartChanged(int totalQty);
    }
}
