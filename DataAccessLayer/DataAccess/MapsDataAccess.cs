using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using CommonClasses;

namespace TrackingWebSite.DataAccessLayer
{
    public class MapsDataAccess : IMapsDataAccess
    {
        public string connectionString { get; set; }
        public MapsDataAccess(string Connection)
        {
            connectionString = Connection;
        }
        public IList<LoginDriverDetails> ValidataLogin()
        {
            IList <LoginDriverDetails> listLoginDriverDetails = null;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                var command = new SqlCommand("usp_GetAllDriverDetails", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 50;
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    listLoginDriverDetails= new List<LoginDriverDetails>();
                    while (dr.Read())
                    {
                        LoginDriverDetails loginDriverDetails = new LoginDriverDetails();
                        loginDriverDetails.DriverName = Convert.ToString(dr["DriverName"]);
                        listLoginDriverDetails.Add(loginDriverDetails);
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return listLoginDriverDetails;
        }
    }
}
