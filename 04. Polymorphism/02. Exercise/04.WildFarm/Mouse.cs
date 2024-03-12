using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Mouse : Mammal
    {
        private const double GainWeight = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }

        public override string LivingRegion { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
                return;
            }
            Weight += food.Quantity * GainWeight;
            FoodEaten += food.Quantity;

        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}