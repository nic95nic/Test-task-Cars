using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Test_task_Cars.Enums;
using Test_task_Cars.Models;

namespace Test_task_Cars.Factory
{
    public static class EngineFactory
    {
        public static Engine GetEngine(TypeAuto typeAuto)
        {
            switch (typeAuto)
            {
                case TypeAuto.Passenger:
                    return new Random().Next(0, 100) % 2 == 0 ? new DieselEngine() : new PertolEngine();
                case TypeAuto.Cargo:
                    return new Random().Next(0, 3) == 2 ? new PertolEngine() : new DieselEngine();
                case TypeAuto.Sport:
                    return new Random().Next(1, 5) == 4 ? new DieselEngine() : new PertolEngine();
                default: throw new Exception("Для чего этот двигатель ? Для самолета чтоли ?");
            }
        }
    }
}
