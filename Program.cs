using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = StringTimes("Hi", 2);
            Console.WriteLine("s1 is:" + s1);

            string s2 = StringTimes("Hi", 3);
            Console.WriteLine("s2 is:" + s2);

            string s3 = StringTimes("Hi", 1);
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }
        public static string StringTimes(string str, int n)
        {
            string s = "";

            for(int i=0;i<n;i++)
            {
                s = s + str;
            }

            return s;
        }
    }
}
