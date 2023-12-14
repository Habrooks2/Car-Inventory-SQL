using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sql.models;
using sql.database;

namespace sql.interfaces
{
    public interface ISaveCar
    {
        void CreateCar(Car myCar);

        void SaveCar(Car myCar);
    }
}