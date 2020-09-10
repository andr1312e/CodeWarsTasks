using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayVI_SharkPontoon
{

    /// <summary>
    /// https://www.codewars.com/kata/57e921d8b36340f1fd000059/train/csharp
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Shark(7, 8, 3, 4, false));
            Console.WriteLine(Shark(26, 6, 2, 1, false));
            Console.ReadKey();

        }
        public static string Shark(
                int pontoonDistance,
                int sharkDistance,
                int yourSpeed,
                int sharkSpeed,
                bool dolphin)
        {
            double RealSharkSpeed;
            if(dolphin)
            {
                RealSharkSpeed = sharkSpeed / 2;
            }
            else
            {
                RealSharkSpeed = (double)sharkSpeed;
            }
            if(pontoonDistance==0|| RealSharkSpeed < yourSpeed)
            return "Alive!";
            else
            {
                if(sharkDistance==0)
                {
                    return ("Shark Bait!");
                }
                double speedDifference = RealSharkSpeed - yourSpeed;
                double time = (sharkDistance-pontoonDistance) / speedDifference;
                if(time<pontoonDistance/yourSpeed)
                return ("Shark Bait!");
                else
                    return "Alive!";
            }
        }
    }
}
////////Дописатьq
