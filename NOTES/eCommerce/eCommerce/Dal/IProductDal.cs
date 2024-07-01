using eCommerce.Models;
using System.Collections.Generic;

namespace eCommerce.Dal
{
    public interface IProductDal
    {
        List<Product> GetAllProducts();
        Product GetProductDetails(int productId);
    }
}
