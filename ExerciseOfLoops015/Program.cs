using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops015
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i1 = { 6, 6, 2 };
            int output = Array667(i1);
            Console.WriteLine("i1 is:" + output);

            int[] i2 = { 6, 6, 2, 6 };
            int output1 = Array667(i2);
            Console.WriteLine("i2 is:" + output1);

            int[] i3 = { 6, 7, 2, 6 };
            int output2 = Array667(i3);
            Console.WriteLine("i3 is:" + output2);
            Console.ReadLine();
        }

        public static int Array667(int[] numbers)
        {
            int count = 0;
            for(int i=0;i<numbers.Length-1;i++)
            {
                if((numbers[i]==6)&&(numbers[i+1]==6)||((numbers[i] == 6)&&(numbers[i+1]==7)))
                {
                    count = 1;
                }
            }


            return count;
        }
    }
}
