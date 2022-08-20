using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_Cars.Interfaces
{
    internal interface IPassengerCarOperation
    {
        void AddPassenger();
        void RemovePassenger();
        public byte MaxPassengerCount { get; set; }
        public byte CurrentPassengerCount { get; set; }
    }
}
