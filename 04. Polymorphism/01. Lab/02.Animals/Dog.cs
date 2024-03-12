
namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string fovouriteFood) : base(name, fovouriteFood)
        {

        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";
        }
    }
}
