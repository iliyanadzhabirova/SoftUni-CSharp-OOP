using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Owl : Bird
    {
        private const double GainWeight = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }

        public override double WingSize { get; set; }
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
            return "Hoot Hoot";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}