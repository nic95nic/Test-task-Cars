using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_task_Cars.Enums;
using Test_task_Cars.Interfaces;

namespace Test_task_Cars.Models
{
    internal class PassengerCar : Auto, IPassengerCarOperation
    {
        public byte MaxPassengerCount { get; set; }
        public byte CurrentPassengerCount { get; set; }
        public PassengerCar(Engine autoEngine, int tankVolume, string nameAuto) 
            : base(autoEngine, tankVolume, nameAuto)
        {
            MaxPassengerCount = DefaultValues.MAX_PASSENGERS_IN_PASSENGER_CAR;
        }

        public override float GetDistanseByFuelVolume(int FuelVolume)
        {
            return base.GetDistanseByFuelVolume(FuelVolume) 
                    - (base.GetDistanseByFuelVolume(FuelVolume) * 0.6f) * CurrentPassengerCount;
        }
        public void RemovePassenger()
        {
            if (CurrentPassengerCount != 0)
                CurrentPassengerCount--;
        }

        public void AddPassenger()
        {
            if (CurrentPassengerCount < MaxPassengerCount)
                CurrentPassengerCount++;
        }
    }
}
