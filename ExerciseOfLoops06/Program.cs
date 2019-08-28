using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops06
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = StringSplosion("Code");
            Console.WriteLine("s1 is:" + s1);
            Console.ReadLine();
        }

        public static string StringSplosion(string str)
        {
            string s = "";

            for (int i = 0; i < str.Length; i++)
            {

                s = s + str.Substring(0, i + 1);
            }
            return s;
        }
    }
}
