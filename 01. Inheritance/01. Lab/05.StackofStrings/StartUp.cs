namespace CustomStack;
public class StartUp
{
    static void Main()
    {
        StackOfStrings stack = new();
        Console.WriteLine(stack.IsEmpty());
        stack.AddRange(new string[] {"Iliyana", "Yoanna", "Evelina", "Krasimir"});
        Console.WriteLine(stack.IsEmpty());
        Console.WriteLine(stack.Count());

    }
}