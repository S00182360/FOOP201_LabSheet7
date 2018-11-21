using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            string[] messages = new string[3];
            messages[0] = "This is message one.";
            messages[1] = "Message two has more words than message one.";
            messages[2] = "message three";
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("There are {0} words in message" + (i+1).ToString(), messages[i].CountWord());
                Console.WriteLine(messages[i]);
                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        public static int CountWord(this string counting)
        {
            string[] NumberofWords = counting.Split(' ');
            return NumberofWords.Length;
        }
    }
}
