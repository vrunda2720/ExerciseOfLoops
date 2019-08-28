using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops010
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = Array123(new int[] { 1, 1, 2, 3, 1 });
            Console.WriteLine("b1 is:" + b1);

            bool b2 = Array123(new int[] { 1, 1, 2, 4, 1 });
            Console.WriteLine("b2 is:" + b2);

            bool b3 = Array123(new int[] { 1, 1, 2, 1, 2, 3 });
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }
        public static bool Array123(int[] numbers)
        {
            bool is123 = false;
            int count = numbers.Length-1;

            for(int i=0;i<count;i++)
            {
                if((numbers[i]==1) && (numbers[i + 1] == 2)&& (numbers[i + 2] == 3))
                {
                    
                  is123 = true;
                }
            }
            return is123;

        }

           
        }
    }

