using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops05
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = EveryOther("Hello");
            Console.WriteLine("s1 is:" + s1);

            string s2 = EveryOther("Hi");
            Console.WriteLine("s2 is:" + s2);

            string s3 = EveryOther("Heeololeo");
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }
        public static string EveryOther(string str)
        {
            string s = "";

            for(int i=0;i<str.Length;i=i+2)
            {
                s = s+str.Substring(i,1);
            }

            return s;
        }
    }
}
