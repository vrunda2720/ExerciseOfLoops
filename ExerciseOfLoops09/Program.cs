using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops09
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1= ArrayFront9(new int[]{ 1, 2, 9,3,4});
            Console.WriteLine("b1 is" + b1);

            bool b2 = ArrayFront9(new int[] { 1, 2, 3,4,9 });
            Console.WriteLine("b2 is" + b2);

            bool b3 = ArrayFront9(new int[] { 1, 2, 3,4,5 });
            Console.WriteLine("b3 is" + b3);
            Console.ReadLine();
        }
        public static bool ArrayFront9(int[] numbers)
        {
            bool isFront9 = false;

            int count = numbers.Length;

            if(count>4)
            {
                count = 4;
            }

            for(int i=0;i<count;i++)
            {
                if(numbers[i]==9)
                {
                    isFront9 = true;
                }
            }


            return isFront9;
        }
    }
}
