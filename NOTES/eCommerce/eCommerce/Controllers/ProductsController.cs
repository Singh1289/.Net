using eCommerce.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductDal _productDal;

        public ProductsController(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public ActionResult Index()
        {
            ViewBag.PageTitle = "Welcome To Infoway Products List!";
            var products = _productDal.GetAllProducts();
            return View(products);
        }
        public ActionResult Details(int id)
        {
            var product = _productDal.GetProductDetails(id);
            ViewBag.DiscountedPrice = product.UnitPrice - ((product.UnitPrice * product.Discount) / 100);
            ViewBag.PageTitle = "Details Of - ";
            return View(product);
        }
    }
}