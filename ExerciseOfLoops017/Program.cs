using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops017
{
    class Program
    {
        static void Main(string[] args)
        {

            bool b1 = Pattern51(new int[] { 1, 2, 7, 1 });
            Console.WriteLine("b1 is:" + b1);

            bool b2 = Pattern51(new int[] { 1, 2, 8, 1 });
            Console.WriteLine("b2 is:" + b2);

            bool b3 = Pattern51(new int[] {  2, 7, 1 });
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }

        public static bool Pattern51(int[] numbers)
        {
            bool is51 = false;

            for (int i = 0; i < numbers.Length-1 ; i++)
            {

                if ((numbers[i]==2)&&(numbers[i+1]==7)&&(numbers[i+2]==1))
                {
                    is51 = true;
                }
}
            return is51;
        }
    }
}
