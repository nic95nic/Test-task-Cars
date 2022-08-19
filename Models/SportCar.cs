using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_Cars.Models
{
    internal class SportCar : Auto
    {
        public SportCar(Engine autoEngine, int tankVolume) : base(autoEngine, tankVolume)
        {
            MaxCountPassengers = DefaultValues.MAX_PASSENGERS_IN_SPORT_CAR;
        }
    }
}
