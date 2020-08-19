using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBL
{

    // Car Connection SingleTone
    public class CarConnection
    {
        private static CarConnection _instance;

        private string connetionString;

        private SqlConnection sqlConnection;

        protected CarConnection()
        {
            connetionString = ConfigurationManager.ConnectionStrings["SQlExpressConnection"].ConnectionString;

            SqlConnection = new SqlConnection(connetionString);

            SqlConnection.Open();
        }

        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }

        public static CarConnection GetInstance()
        {
            if (_instance==null)
            {
                _instance = new CarConnection();
            }    
           
            return _instance;
           
        }

    }
}
