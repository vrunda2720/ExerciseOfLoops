using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops011
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = SubStringMatch("xxcaazz", "xxbaaz");
            Console.WriteLine("i1 is:" + i1);

            int i2 = SubStringMatch("abc", "abc");
            Console.WriteLine("i2 is:" + i2);

            int i3 = SubStringMatch("abc", "axc");
            Console.WriteLine("i3 is:" + i3);
            Console.ReadLine();
        }

        public static int SubStringMatch(string a, string b)
        {

            int count = 0;
            int minLength = Math.Min(a.Length, b.Length);

            for(int i=0;i<minLength-1;i++)
            { 
                    if(a.Substring(i,2).Equals(b.Substring(i,2)))
                    {
                    count++;
                    }
            }
            
            return count;
        }
    }
}
