using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_Cars.Models
{
    public abstract class Auto
    {
        public Engine AutoEngine { get; set; }
        public int TankVolume { get; set; }
        public string NameAuto { get; set; }
        public int Fuel { get; set; }

        public Auto(Engine autoEngine, int tankVolume, string nameAuto)
        {
            AutoEngine = autoEngine;
            TankVolume = tankVolume;
            Fuel = new Random().Next(10, TankVolume);
            NameAuto = nameAuto;
        }

        public virtual float GetDistanseByFuelVolume(int FuelVolume)
        {
            return FuelVolume / AutoEngine.FuelСonsumptionPerOneKm;
        }

        public float GetDistanseByFullTank()
        {
            return GetDistanseByFuelVolume(TankVolume);
        }

    }
}
