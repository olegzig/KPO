using System;

namespace KPO_LR3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tirePressure1 = { 2.2, 2.1, 2.2, 2.3 };
            double[] tirePressure2 = { 2.1, 2.0, 1.8, 2.2 };
            double[] tirePressure3 = { 2.5, 2.5, 2.5, 2.5 };

            Car car1 = new Car("Toyota", "Camry", 70, 50, 120, 8, tirePressure1);
            Car car2 = new Car("BMW", "X5", 80, 60, 140, 10, tirePressure2);
            Car car3 = new Car("Honda", "Civic");

            car3.FuelTankCapacity = 50;
            car3.FuelQuantity = 40;
            car3.CurrentSpeed = 100;
            car3.FuelConsumption = 7;
            car3.TirePressure = tirePressure3;

            Console.WriteLine("Car 1:");
            Console.WriteLine(car1.ToString());
            Console.WriteLine($"Max Range: {car1.MaxRange()} km");
            Console.WriteLine($"Is Flat Tire: {car1.IsFlatTire()}");

            Console.WriteLine("\nCar 2:");
            Console.WriteLine(car2.ToString());
            Console.WriteLine($"Max Range: {car2.MaxRange()} km");
            Console.WriteLine($"Is Flat Tire: {car2.IsFlatTire()}");

            Console.WriteLine("\nCar 3:");
            Console.WriteLine(car3.ToString());
            Console.WriteLine($"Max Range: {car3.MaxRange()} km");
            Console.WriteLine($"Is Flat Tire: {car3.IsFlatTire()}");

            Console.WriteLine("\nComparing cars' speeds:");
            Console.WriteLine($"Is Car 1 faster than Car 2? {Car.FasterCar(car1, car2).Brand} is faster.");
            Console.WriteLine($"Is Car 3 faster than Car 2? {Car.FasterCar(car3, car2).Brand} is faster.");

            Console.WriteLine("\nComparing speeds of three cars:");
            Console.WriteLine($"The fastest car among three is: {Car.FasterCar(car1, car2, car3).Brand}");

            // Демонстрация того, что 2 переменные ссылаются на один объект
            var newobj = car1;
            Console.WriteLine("Car 1:");
            Console.WriteLine(car1.ToString());
            Console.WriteLine("Car \"newobj\":");
            Console.WriteLine(newobj.ToString());
            Console.WriteLine("Set speed to \"0\"");
            newobj.CurrentSpeed = 0;
            Console.WriteLine("Car 1:");
            Console.WriteLine(car1.ToString());
            Console.WriteLine("Car \"newobj\":");
            Console.WriteLine(newobj.ToString());
            Console.ReadKey();
        }
    }
}
