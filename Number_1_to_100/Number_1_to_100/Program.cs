using System;
using System.Linq;

namespace Number_1_to_100;

public static class Program 
{
    public static void Main (string [] args)
    {
        int i = 1;
        while (i <=100)
        {
            Console.WriteLine(i);
            i++;

            if (i % 3 == 0)
            {
                Console.WriteLine("Hello");
                if (i % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                    if (i % 3 % 5 == 0)
                    { 
                    Console.WriteLine("Hello Goodbye");
                    }
                }
            }
        }
     }
}