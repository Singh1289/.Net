using eCommerce.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace eCommerce.Dal
{
    public class UserDal
    {
        private readonly string connectionString;
        public UserDal()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyShoeWorldConStr"].ConnectionString;
        }
        public int RegisterNewUser(User user)
        {
            using (MySqlConnection CN = new MySqlConnection(connectionString))
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
                return result;
            }
        }
        public User CheckCredentials(User user)
        {
            using (MySqlConnection CN = new MySqlConnection(connectionString))
            {
                CN.Open();
                MySqlCommand CMD = new MySqlCommand();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "CheckCredentials";
                CMD.Parameters.AddWithValue("p_Email", user.Email);
                CMD.Parameters.AddWithValue("p_Password", user.Password);
                MySqlDataReader DR = CMD.ExecuteReader();
                DR.Read();
                return new User()
                {
                    Email = DR["Email"].ToString(),
                    Role = DR["Role"].ToString()
                };
            }
        }
    }
}