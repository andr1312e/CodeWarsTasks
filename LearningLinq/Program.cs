using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new int[] {5,6 }));
            Console.WriteLine("---------------");
            Console.WriteLine(CountChar(new char[] { '3', '4' }, '3'));
            Console.WriteLine(CalculateSquares(3,5));
            Console.ReadKey();
        }

        public static int Sum(int[] integers)
        {
            var sum = 0;
            sum += integers.Sum();
            return sum;
        }

        public static int CountChar(char[] chars, char charToCount)
        {
            return chars.Where(c => c == charToCount).ToArray().Length;
        }

        public static int[] CalculateSquares(int start, int end)
        {
            var result = new int[end - start + 1];
            return result.Select((s,i)=>((i+start)*(i+start))).ToArray();
        }
    }
}
