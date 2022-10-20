using System.Collections.Generic;

namespace Palindrome;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("xbx");
        linkedList.AddLast("pka");
        linkedList.AddLast("pka");
        linkedList.AddLast("xbx");
    }

    public static bool IsPalindrome<T>(LinkedList<T> linkedList)
    {
        // if its just one character clearly its gonna be the same forwards and backwards
        if (linkedList.Count == 1)
        {
            return true;
        }
        // Setting
        int count = 0;
        var curNode = linkedList.First;
        var lastNode = linkedList.Last;
        // Node on top must equal the last node
        while (curNode.Value.Equals(lastNode.Value))
        {
            curNode = curNode.Next;
            lastNode = lastNode.Previous;
            count++;
            if (count == linkedList.Count / 2)
            {
                return true;
            }
            
        }
        return false;
    }
}

