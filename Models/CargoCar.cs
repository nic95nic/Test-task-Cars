using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_Cars.Models
{
    public class CargoCar : Auto
    {
        public CargoCar(Engine autoEngine, int tankVolume) : base(autoEngine, tankVolume)
        {
        }
    }
}
