using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling_an_array_part1_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] Arr(int N)
        {
            int[] array = new int[N];
            for (int i=0; i<N; i++)
            {
                array[i] = i;
            }
            return array ;
            //////// return Enumerable.Range(0,N).ToArray();
        }
    }
}
