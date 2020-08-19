using CarCommon.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBL
{
    class DriversDal
    {
        public List<Driver> SelectDrivers()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Driver ", CarConnection.GetInstance().SqlConnection))
            {
                //
                // Add new SqlParameter to the command.
                //
                //command.Parameters.Add(new SqlParameter("Name", dogName));
                //
                // Read in the SELECT results.
                //
                List<Driver> driverList = new List<Driver>();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Driver newDriver = new Driver(reader.GetInt32(0), reader.GetString(2), reader.GetInt32(1), reader.GetString(3), reader.GetInt32(4));

                    driverList.Add(newDriver);
                }
                return new List<Driver>();
            }
        }

        public bool CheckDriverExists(Driver driver)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Driver where id= @ID ", CarConnection.GetInstance().SqlConnection))
            {
                SqlParameter sqlParameter = new SqlParameter("ID", driver.Id);
                command.Parameters.Add(sqlParameter);

                List<Driver> driverList = new List<Driver>();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
                return false;
            }
        }

        public void InsertDriver(Driver driver)
        {
            SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO Drivers VALUES @ID, @DriverName, @Age, @Address, @DriversLessonType", CarConnection.GetInstance().SqlConnection);


            SqlParameter sqlParameter = new SqlParameter("ID", driver.Id);
            sqlCommand.Parameters.Add(sqlParameter);

            SqlParameter sqlParameter1 = new SqlParameter("DriverName", driver.DriverName);
            sqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("Age", driver.Age);
            sqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("Adress", driver.Address);
            sqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("DriversLessonType", driver.DriversLessonType);
            sqlCommand.Parameters.Add(sqlParameter4);

            sqlCommand.ExecuteScalar();
        }

        public void UpdateDriver(Driver driver)
        {
            SqlCommand sqlCommand = new SqlCommand(@"Update Drivers set DriverName = @DriverName, Age=@Age, Adress= @Adress, DriversLessonType=@DriversLessonType where Id = @Id", CarConnection.GetInstance().SqlConnection);

            SqlParameter sqlParameter = new SqlParameter("ID", driver.Id);
            sqlCommand.Parameters.Add(sqlParameter);

            SqlParameter sqlParameter1 = new SqlParameter("DriverName", driver.DriverName);
            sqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("Age", driver.Age);
            sqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("Adress", driver.Address);
            sqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("DriversLessonType", driver.DriversLessonType);
            sqlCommand.Parameters.Add(sqlParameter4);

        }

        public void DeleteDriver(Driver driver)
        {
            SqlCommand sqlCommand = new SqlCommand(@"Delete * from Drivers where Id = @Id", CarConnection.GetInstance().SqlConnection);
            SqlParameter sqlParameter = new SqlParameter("ID", driver.Id);
            sqlCommand.Parameters.Add(sqlParameter);
        }
    }
}
