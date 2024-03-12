using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Tiger : Feline
    {
        private const double GainWeight = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }

        public override string Breed { get; set; }
        public override string LivingRegion { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
                return;
            }
            Weight += food.Quantity * GainWeight;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}