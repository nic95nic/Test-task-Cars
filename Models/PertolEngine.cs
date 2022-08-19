using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_task_Cars.Enums;

namespace Test_task_Cars.Models
{
    internal class PertolEngine : Engine
    {
        public PertolEngine() : base(TypeEngine.Petrol, 10)
        {
        }
    }
}
