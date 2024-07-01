using eCommerce.Api.Models;
using System.Collections.Generic;

namespace eCommerce.Api.Dal
{
    public interface IProductDal
    {
        List<Product> GetAllProducts();
        Product GetProductDetails(int productId);
    }
}
