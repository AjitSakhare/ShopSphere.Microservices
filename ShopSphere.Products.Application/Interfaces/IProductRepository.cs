using System;
using System.Collections.Generic;
using System.Text;
using ShopSphere.Products.Domain.Entities;

namespace ShopSphere.Products.Application.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetAllAsync();

        Task AddAsync(Product Products);
    }
}
