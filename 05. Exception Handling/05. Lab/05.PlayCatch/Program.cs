int[] numbers=Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int exceptionCount = 0;
string[] command;
while (exceptionCount < 3)
{
    try
    {
        command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        if (command[0] == "Replace")
        {
            int index = int.Parse(command[1]);
            int element = int.Parse(command[2]);

            numbers[index] = element;

        }
        else if (command[0] == "Print")
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);
            List<int> newElements = new List<int>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                newElements.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(", ", newElements));
           

        }
        else if (command[0] == "Show")
        {
            int element = int.Parse(command[1]);
            Console.WriteLine(numbers[element]);
        }
    }
    catch (IndexOutOfRangeException)
    {
        exceptionCount++;
        Console.WriteLine("The index does not exist!");
    }
    catch (FormatException)
    {
        exceptionCount++;
        Console.WriteLine("The variable is not in the correct format!");
    }
}
Console.WriteLine(string.Join(", ", numbers));