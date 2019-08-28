using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops016
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = NoTriples(new int[] { 1, 1, 2, 2, 1 });
            Console.WriteLine("b1 is" + b1);

            bool b2 = NoTriples(new int[] { 1, 1, 2, 2, 2, 1 });
            Console.WriteLine("b2 is" + b2);

            bool b3 = NoTriples(new int[] { 1, 1, 1, 2, 2, 2, 1 });
            Console.WriteLine("b3 is" + b3);
            Console.ReadLine();
        }
        public static bool NoTriples(int[] numbers)
        {
            bool isTriples = true;
            for(int i=0;i<numbers.Length-1;i++)
            {
                if((numbers[i]==numbers[i+1])&&(numbers[i+1]==numbers[i+2]))
                {
                    isTriples = false;
                }
            }

            return isTriples;
        }
    }
}
