

using System.Diagnostics.Metrics;

namespace Animals
{
   public class Animal
    {
        public Animal(string name, string fovouriteFood)
        {
            Name = name;
            FovouriteFood = fovouriteFood;
        }

        public string Name { get; protected set; }
        public string FovouriteFood { get; protected set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FovouriteFood}";
        }


    }
}
