
using Test_task_Cars.Enums;

namespace Test_task_Cars.Models
{
    public abstract class Engine
    {
        public bool IsRunning { get; set; }
        public TypeEngine TypeEngine { get; set; }
        public float FuelСonsumptionPerOneKm { get; set; }
        public float FuelСonsumptionPerOneHundredKm { get; set; }

        public Engine(TypeEngine typeEngine, float fuelСonsumptionPerOneHundredKm)
        {
            TypeEngine = typeEngine;
            FuelСonsumptionPerOneHundredKm = fuelСonsumptionPerOneHundredKm;
            FuelСonsumptionPerOneKm = fuelСonsumptionPerOneHundredKm / 100;
        }

        
        // TODO Сделать уменьшение топлива при запущеном двигателе
        public virtual bool TryStart()
        {
            if (IsRunning) return false;
            IsRunning = true;
            return true;
        }

        public virtual bool TryTurnOff()
        {
            if (!IsRunning) return false;
            IsRunning = false;
            return true;
        }

        public override string ToString()
        {
            return TypeEngine switch
            {
                TypeEngine.Diesel => "Дизельный мотор",
                TypeEngine.Electric => "Электродвигатель",
                TypeEngine.Petrol => "Бензиновый мотор",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
