
namespace Test_task_Cars.Interfaces
{
    internal interface IPassengerCarOperations
    {
        void AddPassenger();
        void RemovePassenger();
        public byte MaxPassengerCount { get; set; }
        public byte CurrentPassengerCount { get; set; }
    }
}
