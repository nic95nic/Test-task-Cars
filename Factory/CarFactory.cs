using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_task_Cars.Enums;
using Test_task_Cars.Models;

namespace Test_task_Cars.Factory
{
    public static class CarFactory
    {
        public static Auto GetAuto(TypeAuto typeAuto, string nameAuto)
        {
            Engine engine = EngineFactory.GetEngine(typeAuto);
            switch (typeAuto)
            {
                case TypeAuto.Cargo:
                    return new CargoCar(engine, 400, nameAuto, 10000);
                case TypeAuto.Passenger:
                    return new PassengerCar(engine, 50, nameAuto);
                case TypeAuto.Sport:
                    return new SportCar(engine, 100, nameAuto);
                default:
                    throw new Exception("Это не автомобиль, самолет чтоли?");
            }
        }
    }
}
