using System;

namespace LoopingConstructs
{
    //  This program demo. how to write for each loop.
    class ForEachLoop
    {
        static void Main()
        {
         
          
            //  To use foreach loop we must have variable of type array or collection.
            int[] numsArray = {10,20,30,40,50 };

            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.Write($"{numsArray[i]}\t");
            //}

            foreach (var num in numsArray)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine();

            string[] strArray = {"str1","str2","str3" };

            foreach(var str in strArray)
            {
                Console.Write($"{str}\t");
            }
            Console.ReadLine();
        }
    }
}
