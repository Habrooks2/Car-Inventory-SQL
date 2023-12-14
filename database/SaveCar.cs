using sql.interfaces;
using sql.models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace sql.database
{
    
    public class SaveCar: ISaveCar
    {
        public static void CreateCarTable(){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE cars(carID INTEGER PRIMARY KEY AUTO_INCREMENT, carMake TEXT, carModel TEXT, carMileage INT, carDate DATE, carHold BINARY)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }

        public void CreateCar(Car myCar){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO cars(carID, carMake, carModel, carMileage, carDate, carHold) VALUES (@carID, @carMake, @carModel, @carMileage, @carDate, @carHold)";

            using var cmd = new MySqlCommand(stm,con);

            cmd.Parameters.AddWithValue("@carID", myCar.carID);
            cmd.Parameters.AddWithValue("@carMake", myCar.carMake);
            cmd.Parameters.AddWithValue("@carModel", myCar.carModel);
            cmd.Parameters.AddWithValue("@carMileage", myCar.carMileage);
            cmd.Parameters.AddWithValue("@carDate", myCar.carDate);
            cmd.Parameters.AddWithValue("@carHold", myCar.carHold);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }

        void ISaveCar.SaveCar(Car myCar){

            throw new System.NotImplementedException();
        }
    }
}