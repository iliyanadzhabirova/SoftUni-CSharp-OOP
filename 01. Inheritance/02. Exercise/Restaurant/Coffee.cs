namespace Restaurant;

public class Coffee : HotBeverage
{
    
    private const double CoffeeMililiters = 50;
    private const decimal CoffeePrice = 3.50m;

    
    public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMililiters)
    {
        Caffeine = caffeine;
    }

   
    public double Caffeine { get; private set; }
}
