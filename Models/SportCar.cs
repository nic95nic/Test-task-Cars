using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_task_Cars.Interfaces;

namespace Test_task_Cars.Models
{
    internal class SportCar : Auto, IPassengerCarOperation
    {
        public byte MaxPassengerCount { get; set; }
        public byte CurrentPassengerCount { get; set; }

        public SportCar(Engine autoEngine, int tankVolume, 
            string nameAuto) : base(autoEngine, tankVolume, nameAuto)
        {
            MaxPassengerCount = DefaultValues.MAX_PASSENGERS_IN_SPORT_CAR;
            CurrentPassengerCount = 0;
        }


        public void AddPassenger()
        {
            throw new NotImplementedException();
        }

        public void RemovePassenger()
        {
            throw new NotImplementedException();
        }
    }
}
