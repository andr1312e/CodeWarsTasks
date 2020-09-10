using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can_we_divide_it
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_divide_by(-12, 2, 6));
            Console.WriteLine(is_divide_by(-12, 2, -5));
            Console.WriteLine(is_divide_by(-45, 1, 6));
            Console.WriteLine(is_divide_by(45, 5, 15));
            Console.WriteLine(is_divide_by(4, 1, 4));
            Console.WriteLine(is_divide_by(15, -5, 3));
            Console.ReadKey();
        }
        public static bool is_divide_by(int number, int a, int b)
        {
            if (a == 0 || b == 0 || number == 0)
                return false;
            int tmp;
            
            if(Math.Abs(number) > Math.Abs(a))
            {
                tmp = a;
                a = number;
                number = tmp;
            }
            if (Math.Abs(number) > Math.Abs(b))
            {
                tmp = b;
                b = number;
                number = tmp;
            }
            if(Math.Abs(a) > Math.Abs(b))
            {
                tmp = b;
                b = a;
                a = tmp;
            }
            if (b % number == 0 && b % a == 0)
                return true;
            return false;
            
        }
    }
}
