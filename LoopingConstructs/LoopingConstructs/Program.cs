using System;

namespace LoopingConstructs
{
    class Program
    {
        //  This program demo. how to write for loop.
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int sum = 0;
            for (int i = 1; i <= 15; i++)
            {
                sum = sum + i;
                //Console.WriteLine("Sum is {0}", sum);
                Console.Write($"Sum is {sum}\n");
            }

            Console.ReadLine();
        }
    }
}
