using _08.CollectionHierarchy.Models;
using System.Text;

namespace _08.CollectionHierarchy;
public class Program
{
    static void Main()
    {
        var input=Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries);
        int removeCommandsCount=int.Parse(Console.ReadLine());

        StringBuilder sb=new StringBuilder();

        AddCollection addCollection= new AddCollection();
        AddRemoveCollection addRemoveCollection= new AddRemoveCollection();
        MyList myList= new MyList();

        for (int i = 0; i < 3; i++)
        {
            for (int c = 0; c  < input.Length; c++)
            {
                if (i==0)
                {
                    var index = addCollection.Add(input[c]);
                    sb.Append(index.ToString() + " ");
                }
                else if (i==1) 
                {
                     var index = addRemoveCollection.Add(input[c]);
                     sb.Append(index.ToString() + " ");
                }
                else
                {
                    var index = myList.Add(input[c]);
                    sb.Append(index.ToString() + " ");
                }
            }
            sb.AppendLine();
        }
        for (int i = 0; i < 2; i++)
        {
            for (int c = 0; c < removeCommandsCount; c++)
            {
                if (i == 0)
                {
                    sb.Append(addRemoveCollection.Remove() + ' ');
                }

                else
                {
                    sb.Append(myList.Remove() + ' ');
                }

            }
            sb.AppendLine();
        }
        Console.Write(sb);
       
    }
    private static string IndexToString(int index)
    {
        var result = index.ToString();
        return result;
    }

}