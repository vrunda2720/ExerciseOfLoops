using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops013
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = AltPairs("kitten");
            Console.WriteLine("s1 is:" + s1);

            string s2 = AltPairs("Chocolate");
            Console.WriteLine("s2 is:" + s2);

            string s3 = AltPairs("CodingHorror");
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }

        public static string AltPairs(string str)
        {
            string s = "";

            for (int i = 0; i < str.Length; i=i + 4)
            {
                s = s + str[i];

                if (i + 1 < str.Length)
                {
                    s = s + str[i + 1];
                }
            }

           

            return s;
        }
    }
}
