using System.Runtime.CompilerServices;

namespace Restaurant;

public class Fish : MainDish
{
    
    private const double FishGrams = 22;

    
    public Fish(string name, decimal price) : base(name, price, FishGrams) {}
}
