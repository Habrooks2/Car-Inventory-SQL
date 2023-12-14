using sql.database;
using sql.interfaces;
using System;
using sql.models;


namespace sql{

    class Program{

        static void Main(string[] args){

        
            Car myCar = new Car(){carID = 1000,carMake = "Honda", carModel = "Civic", carMileage = 58600, carDate = new DateTime(2023, 12, 12), carHold = false};
            myCar.Save.CreateCar(myCar);
            //SaveCar.CreateCar();
            Console.WriteLine("Saved!");
        }

    }
}
