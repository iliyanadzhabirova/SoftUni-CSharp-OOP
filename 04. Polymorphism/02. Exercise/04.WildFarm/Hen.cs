using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Hen : Bird
    {
        private const double GainWeight = 0.35;
        public Hen(string name, double weight, double wingSize)
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
            Weight += food.Quantity * GainWeight;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}