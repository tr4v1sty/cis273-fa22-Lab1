using System.Collections.Generic;

namespace KthToLast;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();
        for (int i = 0; i <= 40; i++)
        {
            list.Append(i);
        }
        for (int i = 0; i <= 40; i++)
        {
            Console.WriteLine(((40 - i), list.KthToLast(i)));
        }
    }
}




