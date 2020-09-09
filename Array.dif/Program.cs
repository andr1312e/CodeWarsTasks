using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Array.diff
/// https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
/// </summary>
namespace Arraydiff
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2 };
            var b = new int[] { 2,4,5,5,5,5 };
            var arr = ArrayDiff(a, b);
            foreach(var num in arr)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            bool isNotIncluded = true;
            int arraySize = 0;
            int[] tempArray;
            int[] finalyArray=new int[arraySize];
            foreach(var value_a in a)
            {
                foreach(var value_b in b)
                {
                    if (value_b==value_a)
                    {
                        isNotIncluded = false;
                    }
                }
                if (isNotIncluded)
                {
                    arraySize++;
                    tempArray = new int[arraySize];
                    System.Array.Copy(finalyArray, tempArray, arraySize - 1);
                    tempArray[arraySize - 1] = value_a;
                    finalyArray = tempArray;
                    tempArray = null;
                }
                isNotIncluded = true;
            }
            return finalyArray;
        }
    }
}
