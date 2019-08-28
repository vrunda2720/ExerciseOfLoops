using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 9 };
            int output = Count9(a1);
            Console.WriteLine("a1 value:" + output);

           int[] a2= { 1, 9, 9};
            int output1 = Count9(a2);
            Console.WriteLine("a2 value:" + output1);

            int[] a3 = { 1, 9, 9,3,9 };
            int output2 = Count9(a3);
            Console.WriteLine("a3 value:" + output2);
            Console.ReadLine();
        }

        public static int Count9(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    count++;
                }
            }
             return count;

            
        }
    }
}

