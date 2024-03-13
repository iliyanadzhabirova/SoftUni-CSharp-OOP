
namespace _04.SumOfIntegers
{
  
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string element ;


            string[] input = Console.ReadLine().Split(" ");

            for (int i = 0; i < input.Length; i++)
            {
                element = input[i];

                int currentNum = 0;
                try
                {
                    currentNum = int.Parse(element);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }

                sum += currentNum;
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");

            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}