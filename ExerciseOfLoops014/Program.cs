using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfLoops014
{
    class Program
    {
        static void Main(string[] args)
        {
           string s1= DoNotYak("yakpak");
            Console.WriteLine("s1 is:" + s1);
            Console.ReadLine();
        }

        public static string DoNotYak(string str)
        {

            StringBuilder s = new StringBuilder(str);
            for(int i=0;i<(s.Length)-2;i++)
            {
                if((s[i]=='y')&&(s[i+2]=='k'))
                {
                    s.Remove(i,3);
                }
            }

            return s.ToString();
        }
    }
}
