using System.Collections.Generic;
using Testing.Models;

namespace Testing.Data;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}