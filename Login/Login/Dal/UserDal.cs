using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using Login.Models;
using MySql.Data.MySqlClient;

namespace Login.Dal
{
    public class UserDal
    {
        private String connection;

        public UserDal()
        {
           connection = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        }

        public User checkCredential(User u1) 
        {
            User temp;
            using (MySqlConnection CN = new MySqlConnection(connection))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand() )
                {
                    
                    CMD.Connection = CN;
                    CMD.CommandType = System.Data.CommandType.StoredProcedure;
                    CMD.CommandText = "checkUser";
                    CMD.Parameters.AddWithValue("p_email", u1.Email);
                    CMD.Parameters.AddWithValue("p_password", u1.Password);
                    MySqlDataReader DR = CMD.ExecuteReader();
                    temp = new User()
                    {
                        Email = DR["Email"].ToString(),
                        Role = DR["Role"].ToString()
                    };
                    DR.Close();
                }
              CN.Close();               
            }
         return temp;    
        }

        public int RegisterNewUser(User user)
        {
            using (MySqlConnection CN = new MySqlConnection(connection))
            {
                CN.Open();
                MySqlCommand CMD = new MySqlCommand();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "InsertUser";
                CMD.Parameters.AddWithValue("p_Email", user.Email);
                CMD.Parameters.AddWithValue("p_Password", user.Password);
                CMD.Parameters.AddWithValue("p_Role", user.Role);
                int result = CMD.ExecuteNonQuery();
                CN.Close();
                return result;
            }
        }
    }
}