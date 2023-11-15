﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp
{
    public interface ICookingRepository
    {        
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task<Order> GetOrderAsync(string id, string customerId);
        Task<IEnumerable<Order>> GetOrdersByQueryAsync(string query);
        Task AddOrderAsync(Order Order);
        Task UpdateOrderAsync(string id, Order Order);
    }
}