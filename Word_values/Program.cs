using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)'b');
            string[] str = new string[] { "codewars", "abc", "xyz" };
            WordValue(str);
            Console.ReadKey();
        }
        public static int[] WordValue(string[] a)
        {
            if (a.Length == 0)
                return new int[] { 0 };
            int[] array = new int[a.Length];
            int index = 0;
            foreach (string word in a)
            {
                foreach (char charecter in word)
                {
                    if (charecter != ' ')
                    {
                        array[index] += (int)charecter - 96;
                    }

                }
                array[index] *= (index + 1);
                index++;
            }
            return array;
        }
    }
}
