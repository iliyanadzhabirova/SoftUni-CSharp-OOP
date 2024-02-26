using System;
namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int horsePower = 450;
            double fuel = 100;

            SportCar sportCar = new SportCar(horsePower, fuel);

            double kilometers = 5;

            sportCar.Drive(kilometers);


            Console.WriteLine($"{sportCar.HorsePower} {sportCar.Fuel} {sportCar.DefaultFuelConsumption} {sportCar.FuelConsumption}");
        }
    }
}
