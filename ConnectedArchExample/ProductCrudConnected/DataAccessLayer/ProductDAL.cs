using MySql.Data.MySqlClient;
using ProductCrudConnected.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace ProductCrudConnected.DataAccessLayer
{
    internal class ProductDAL
    {
        private String _conStr = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

        public List<Products> GetAllProducts()
        {
            List<Products> proList = new List<Products>();
            using (MySqlConnection con = new MySqlConnection(_conStr))
            {
                con.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = con;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "getAllProducts";
                    MySqlDataReader DR = CMD.ExecuteReader(CommandBehavior.SequentialAccess);
                    while (DR.Read())
                    {
                        Products pro = new Products()
                        {
                            productID = Convert.ToInt32(DR["productID"]),
                            productName = DR["productName"].ToString(),
                            productPrice = Convert.ToInt32(DR["productPrice"])
                        };
                        proList.Add(pro);
                    }
                    DR.Close();
                }
                con.Close();
            }
            return proList;
        }

        public int InsertProduct(Products product)
        {
            int result = -1;
            using (MySqlConnection con = new MySqlConnection(_conStr))
            {
                con.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = con;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "insertProduct";                  
                    CMD.Parameters.AddWithValue("nam", product.productName);
                    CMD.Parameters.AddWithValue("price", product.productPrice);
                    result = CMD.ExecuteNonQuery();
                }
                con.Close();
            }
            return result;
        }


        public int UpdateProduct(Products product)
        {
            int result = -1;
            using (MySqlConnection CN = new MySqlConnection(_conStr))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "updateProduct";
                    CMD.Parameters.AddWithValue("id", product.productID);
                    CMD.Parameters.AddWithValue("nam", product.productName);
                    CMD.Parameters.AddWithValue("price", product.productPrice);
                    //nam and price are the store procedure input variable
                    result = CMD.ExecuteNonQuery();
                }
                CN.Close();
            }
            return result;
        }

        public int DeleteProduct(int ID)
        {
            int result = -1;
            using (MySqlConnection CN = new MySqlConnection(_conStr))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "deleteProduct";
                    CMD.Parameters.AddWithValue("id", ID);

                    result = CMD.ExecuteNonQuery();
                }
                CN.Close();
            }
            return result;
        }
    }
}
