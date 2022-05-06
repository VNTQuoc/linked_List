using System;
namespace linkedlist
{
    class Node
    {
        static void Main(string[] args)
        {
            LinkedList<string> numbers = new LinkedList<string>();

            var num9 = numbers.AddFirst("9");
            var num8 = numbers.AddLast("8");

            var num3 = numbers.AddAfter(num9, "3");
            var num4 = numbers.AddAfter(num3, "4");
            var num7 = numbers.AddAfter(num4, "7");

            foreach (var data in numbers)
            {
                Console.WriteLine(data);
            }    
        }
    }
}
