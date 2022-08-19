using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_task_Cars.Enums;

namespace Test_task_Cars.Models
{
    internal class DieselEngine : Engine
    {
        public DieselEngine() : base(TypeEngine.Diesel, 8)
        {
        }
    }
}
