﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_task_Cars.Enums;

namespace Test_task_Cars.Models
{
    internal class PassengerCar : Auto
    {
        public PassengerCar(Engine autoEngine, int tankVolume) 
            : base(autoEngine, tankVolume)
        {
            MaxCountPassengers = DefaultValues.MAX_PASSENGERS_IN_PASSENGER_CAR;
        }

        public override float GetDistanseByFuelVolume(int FuelVolume)
        {
            return base.GetDistanseByFuelVolume(FuelVolume) 
                    - (base.GetDistanseByFuelVolume(FuelVolume) * 0.6f) * MaxCountPassengers;
        }
    }
}