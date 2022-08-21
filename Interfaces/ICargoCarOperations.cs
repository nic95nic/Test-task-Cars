
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
