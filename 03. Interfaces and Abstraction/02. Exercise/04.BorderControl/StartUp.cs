using _04.BorderControl.Models;

namespace _04.BorderControl;

public class StartUp
{
    static void Main()
    {
        Models.BorderControl borderControl = new();
        string input;

        while ((input=Console.ReadLine())!="End")
        {
            string[] tokens=input
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length==2) // We have a robot!
            {
                Robot robot=new(tokens[1], tokens[0]);
                borderControl.AddEntityForBorderCheck(robot);
            }
            else
            {
              Citizen citizen = new(tokens[2], int.Parse(tokens[1]), tokens[0]);
                borderControl.AddEntityForBorderCheck(citizen);
            }
        }
        string fakeIdEndSequance=Console.ReadLine();
        var detained = borderControl.EntitiesToBeChecked
            .Where(e => e.Id.EndsWith(fakeIdEndSequance));

        foreach (var baseEntity in detained)
        {
            Console.WriteLine(baseEntity.Id);
        }
    }
}