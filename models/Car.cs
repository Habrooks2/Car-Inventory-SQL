using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sql.database;
using sql.interfaces;

namespace sql.models
{
    public class Car
    {
        public int carID {get; set;}
        public string? carMake {get; set;}
        public string? carModel {get; set;}
        public int carMileage {get; set;}
        public DateTime? carDate {get; set;}
        public bool carHold {get; set;}

        public ISaveCar Save {get;set;}

        public Car(){
            Save = new SaveCar();
        }
    }
}