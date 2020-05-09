using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using iChefWebApi.Configuration;
using iChefWebApi.Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace iChefWebApi.Controller
{
    public class UserController : ApiController
    {
        [HttpPost]
        public User Login(string username, string password)
        {
            User response = null;
            using (MySqlConnection conn = WebApiConfig.DatabaseConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("Login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_username", username);
                    cmd.Parameters.AddWithValue("p_password", password);

                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while(dataReader.Read())
                        {
                            response = new User((int)dataReader["userid"]);
                        }
                    }
                }
            }
            return response;
        }
    }
}
