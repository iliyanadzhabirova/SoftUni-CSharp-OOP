namespace CustomRandomList;
public class StartUp
{
    static void Main()
    {
        var randomList = new RandomList
            {
                "Katerina",
                "Slaveya",
                "Gosho",
                "Gabriela",
                "Nikolay"
            };

        Console.WriteLine(randomList.RandomString());
    }
}