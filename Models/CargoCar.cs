
using Test_task_Cars.Interfaces;

namespace Test_task_Cars.Models
{
    public class CargoCar : Auto, ICargoCarOperations
    {
        public float CurrentWeight { get; set; }
        public int MaxWeight { get; set; }

        public CargoCar(Engine autoEngine, int tankVolume, string nameAuto, int maxWeight) : base(autoEngine, tankVolume, nameAuto)
        {
            MaxWeight = maxWeight;
            CurrentWeight = 0.00f;
        }

        public void AddWeight(float weight)
        {
            if (weight > MaxWeight)
                return;
            CurrentWeight += weight;
        }

        public void RemoveWeight(float weight)
        {
            if (weight > CurrentWeight)
                return;
            CurrentWeight -= weight;
        }

        public override float GetDistanseByFuelVolume(int FuelVolume)
        {
            return base.GetDistanseByFuelVolume(FuelVolume) 
                   - base.GetDistanseByFuelVolume(FuelVolume) / 100 * (0.02f * CurrentWeight);
        }
    }
}
