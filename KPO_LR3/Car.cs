using System;

namespace KPO_LR3
{
    public class Car
    {
        private string brand;
        private string model;
        private double fuelTankCapacity;
        private double fuelQuantity;
        private double currentSpeed;
        private double fuelConsumption;
        private double[] tirePressure;

        public string Brand
        {
            get;set;
        }

        public string Model
        {
            get;set;
        }

        public double FuelTankCapacity
        {
            set
            {
                if (value > 0)
                    fuelTankCapacity = value;
            }
        }

        public double FuelQuantity
        {
            set
            {
                if (value >= 0 && value <= fuelTankCapacity)
                    fuelQuantity = value;
            }
        }

        public double CurrentSpeed
        {
            set
            {
                if (value >= 0)
                    currentSpeed = value;
            }
        }

        public double FuelConsumption
        {
            set
            {
                if (value >= 0)
                    fuelConsumption = value;
            }
        }

        public double[] TirePressure
        {
            set
            {
                if (value.Length == 4)
                    tirePressure = value;
            }
        }

        public Car(string brand, string model, double fuelTankCapacity, double fuelQuantity, double currentSpeed, double fuelConsumption, double[] tirePressure)
        {
            Brand = brand;
            Model = model;
            FuelTankCapacity = fuelTankCapacity;
            FuelQuantity = fuelQuantity;
            CurrentSpeed = currentSpeed;
            FuelConsumption = fuelConsumption;
            TirePressure = tirePressure;
        }

        public Car(string brand, string model, double fuelTankCapacity, double fuelQuantity, double fuelConsumption)
            : this(brand, model, fuelTankCapacity, fuelQuantity, 0, fuelConsumption, new double[4]) { }

        public Car(string brand, string model)
            : this(brand, model, 60, 0, 0, 0, new double[4]) { }

        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Fuel Quantity: {fuelQuantity}, Current Speed: {currentSpeed}, Fuel Consumption: {fuelConsumption}, Tire Pressure: [{string.Join(", ", tirePressure)}]";
        }

        public double MaxRange()
        {
            return fuelQuantity / fuelConsumption * 100;
        }

        public bool IsFlatTire()
        {
            foreach (var pressure in tirePressure)
            {
                if (pressure < 2.0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsFasterThan(Car otherCar)
        {
            return currentSpeed > otherCar.currentSpeed;
        }

        public static Car FasterCar(Car car1, Car car2)
        {
            return car1.currentSpeed > car2.currentSpeed ? car1 : car2;
        }

        public static Car FasterCar(Car car1, Car car2, Car car3)
        {
            Car fastestCar = car1;
            if (car2.currentSpeed > fastestCar.currentSpeed)
            {
                fastestCar = car2;
            }
            if (car3.currentSpeed > fastestCar.currentSpeed)
            {
                fastestCar = car3;
            }
            return fastestCar;
        }
    }
}
