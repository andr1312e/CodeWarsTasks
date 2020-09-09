using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_thPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4 };
            Console.WriteLine(Index(arr,2));
            Console.ReadKey();
        }
        public static double Index(int[] array, int n)
        {
            if(array.Length<=n)
            {
                return -1;
            }
            else
            {
                return (int)Math.Pow(array[n], n);
            }
        }
    }
}
