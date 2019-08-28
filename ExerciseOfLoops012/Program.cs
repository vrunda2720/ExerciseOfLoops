using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops012
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = StringX("abxxxcd");
            Console.WriteLine("s1 is:" + s1);
            Console.ReadLine();
        }

        public static string StringX(string str)
        {
            string s = "";
         var first = str[0];
         var last = str[str.Length - 1];
            StringBuilder s1 = new StringBuilder();

            var middle = str.Substring(1, str.Length - 2);

            for (int i = 0; i < middle.Length; i++)
            {
                if (middle[i] != 'x')
                {
                    s1.Append(middle[i]);
                }
                
            }


            return first+s1.ToString()+last;
        }
    }
}
