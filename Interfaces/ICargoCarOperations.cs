using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_Cars.Interfaces
{
    internal interface ICargoCarOperations
    {
        void AddWeight(float weight);
        void RemoveWeight(float weight);
        public float CurrentWeight { get; set; }
        public int MaxWeight { get; set; }
    }
}
