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
        public byte MaxCountPassengers { get; set; }
        public byte CountPassengers { get; set; }
        public byte MaxСarryingСapacity { get; set; }
        public byte СarryingСapacity { get; set; }

        public Auto(Engine autoEngine, int tankVolume)
        {
            AutoEngine = autoEngine;
            TankVolume = tankVolume;
        }

        public virtual float GetDistanseByFuelVolume(int FuelVolume)
        {
            return FuelVolume / AutoEngine.FuelСonsumptionPerOneKm;
        }

        public float GetDistanseByFullTank()
        {
            return GetDistanseByFuelVolume(TankVolume);
        }

        public void RemovePassenger()
        {
            if (CountPassengers != 0)
                CountPassengers--;
        }

        public void AddPassenger()
        {
            if (CountPassengers != MaxCountPassengers)
                CountPassengers++;
        }
        public void RemoveCargo(int weight)
        {
            if (MaxCountPassengers != 0)
                MaxCountPassengers--;
        }

        public void AddCargo(int weight)
        {
            if (MaxCountPassengers != MaxCountPassengers)
                MaxCountPassengers++;
        }
    }
}
