using eCommerce.Api.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eCommerce.Api.Dal
{
    public class ProductDal : IProductDal
    {
        private readonly string _connectionString;
        public ProductDal()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyShoeWorldConStr"].ConnectionString;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (MySqlConnection CN = new MySqlConnection(_connectionString))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = System.Data.CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllProducts";
                    MySqlDataReader DR = CMD.ExecuteReader(System.Data.CommandBehavior.SequentialAccess);
                    while (DR.Read())
                    {
                        Product product = new Product()
                        {
                            ProductId = Convert.ToInt32(DR["ProductId"]),
                            ProductName = DR["ProductName"].ToString(),
                            Description = DR["Description"].ToString(),
                            UnitPrice = Convert.ToDecimal(DR["UnitPrice"]),
                            Picture = DR["Picture"].ToString()
                        };
                        products.Add(product);
                    }
                    DR.Close();
                }
                CN.Close();
            }
            return products;
        }

        public Product GetProductDetails(int productId)
        {
            Product product;
            using (MySqlConnection CN = new MySqlConnection(_connectionString))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = System.Data.CommandType.StoredProcedure;
                    CMD.CommandText = "GetOneProduct";
                    CMD.Parameters.AddWithValue("p_ProductID", productId);
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DR.Read();
                    product = new Product() 
                    {
                        ProductId = Convert.ToInt32(DR["ProductId"]),
                        ProductName = DR["ProductName"].ToString(),
                        Description = DR["Description"].ToString(),
                        UnitPrice = Convert.ToDecimal(DR["UnitPrice"]),
                        Picture = DR["Picture"].ToString(),
                        Discount =Convert.ToInt32(DR["Discount"])
                    };
                    DR.Close(); 
                }
                CN.Close();
            }
            return product;
        }
    }
}