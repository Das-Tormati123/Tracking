using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataAccessLayer.DataBase;
using KT_POC;
using System.Runtime.Remoting.Messaging;
using CommonClasses;

namespace TrackingWebSite.DataAccessLayer
{
    public class LoginDataAccess : ILoginDataAccess
    {
        public string connectionString { get; set; }
        public LoginDataAccess(string Connection)
        {
            connectionString = Connection;
        }
        public bool ValidataLogin(string UserName, string Password)
        {
            bool LoginSuccess = false;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var command = new SqlCommand("usp_LoginCheck", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 50;
                command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
                SqlDataReader dr = command.ExecuteReader();
                byte[] Salt = null;
                byte[] PasswordBinary = null;
                if (dr.HasRows)
                {
                    dr.Read();
                    Salt = (byte[])dr["Salt"];
                    PasswordBinary = (byte[])dr["PasswordBinary"];
                }
                if (Salt != null && PasswordBinary != null)
                {
                    PasswordEncrypt passwordEncrypt = null;
                    passwordEncrypt = new PasswordEncrypt();
                    string stringData = System.Text.Encoding.ASCII.GetString(Salt);
                    string PasswordEncrypt = System.Text.Encoding.ASCII.GetString(PasswordBinary);
                    // UTF8
                    string sringData = System.Text.Encoding.UTF8.GetString(Salt);
                    // Verify the password
                    //string PasswordEncrypt = passwordEncrypt.HashPassword(Password, Salt);
                    LoginSuccess = (passwordEncrypt.HashPassword(Password, stringData) == PasswordEncrypt);

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return LoginSuccess;
        }
    }
}
