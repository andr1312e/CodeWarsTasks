using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turkish_Numbers_0_99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTurkishNumber(10));
            Console.ReadKey();
        }
        public static string GetTurkishNumber(int num)
        {
            Dictionary<int, string> TurkishDictonary = new Dictionary<int, string>();
            TurkishDictonary.Add(0, "sıfır");
            TurkishDictonary.Add(1, "bir");
            TurkishDictonary.Add(2, "iki");
            TurkishDictonary.Add(3, "üç");
            TurkishDictonary.Add(4, "dört");
            TurkishDictonary.Add(5, "beş");
            TurkishDictonary.Add(6, "altı");
            TurkishDictonary.Add(7, "yedi");
            TurkishDictonary.Add(8, "sekiz");
            TurkishDictonary.Add(9, "dokuz");
            TurkishDictonary.Add(10, "on");
            TurkishDictonary.Add(20, "yirmi");
            TurkishDictonary.Add(30, "otuz");
            TurkishDictonary.Add(40, "kırk");
            TurkishDictonary.Add(50, "elli");
            TurkishDictonary.Add(60, "altmış");
            TurkishDictonary.Add(70, "yetmiş");
            TurkishDictonary.Add(80, "seksen");
            TurkishDictonary.Add(90, "doksan");
            string result = string.Empty;
            if(num/10>0)
            {
                result += TurkishDictonary[((num / 10) * 10)];
                result += " ";
            }
            if(num ==0||num%10!=0)
            result += TurkishDictonary[((num % 10))];
            return result;
        }
    }
}
