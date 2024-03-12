
namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string fovouriteFood) : base (name, fovouriteFood) 
        {
        
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }
    }
}
