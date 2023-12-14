using sql.interfaces;
using sql.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace sql.database
{
    public class DeleteCar: IDeleteCar
    {
        public static void DropCarTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS cars";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

        }

        public void SoftDeleteCar(int id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE cars SET IsDeleted = 1 WHERE carID = @carID";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@carID", id);

            cmd.ExecuteNonQuery();
        }


        void IDeleteCar.DeleteCar(int carID)
        {
            throw new System.NotImplementedException();
        }
    }
}