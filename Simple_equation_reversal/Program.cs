using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_equation_reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)'0');
            Console.WriteLine(solve("100*b/y/100"));
            Console.ReadKey();
        }
        public static string solve(string eq)
        {
            char[] arr = eq.ToCharArray();
            string result = string.Empty;
            string forNumbers = string.Empty;
            for (int i=eq.Length-1; i>=0; i--)
            {
                if((int)(arr[i])>=48&&((int)arr[i]<=57))
                {
                    forNumbers += arr[i];
                }
                else
                {
                    if(forNumbers!=string.Empty)
                    {
                        char[] forReverce = forNumbers.ToArray();
                        forReverce = forReverce.Reverse().ToArray();
                        forNumbers = new string(forReverce);
                        result += forNumbers;
                        forNumbers = string.Empty;
                    }
                    result += arr[i];
                }
                if(i==0)
                {
                   if (forNumbers != string.Empty)
                    {
                        char[] forReverce = forNumbers.ToArray();
                        forReverce = forReverce.Reverse().ToArray();
                        forNumbers = new string(forReverce);
                        result += forNumbers;
                        forNumbers = string.Empty;
                    }
                }
            }
            return result;
        }
    }
}
