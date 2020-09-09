using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("This is my first ROT13 excercise!"));
            char aa = '0';
            string LatinAlphaber = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            if ((int)aa <= ((int)'9' - 5))
            {
                aa = (char)((int)aa + 5);
            }
            else
            {
                aa = (char)(5 - ((int)'9' - (int)aa) + (int)'0');
            }


            Console.WriteLine((char)((int)'9'-5));
            Console.ReadKey();
        }
        public static string Rot13(string message)
        {
            string LatinAlphaber = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string Numbers = "0123456789";
            string result = string.Empty;
            foreach(char character in message)
            {
                Console.WriteLine(character);
                if (LatinAlphaber.Contains(character))
                {
                    if ((int)character > (int)'a')
                    {
                        if ((int)character < ((int)'z' - 5))
                        {
                            result += (char)((int)character + 5);
                        }
                        else
                        {
                            result += (char)(5 - ((int)'z' - (int)character) + (int)'a');
                        }
                    }
                    else
                    {
                        if ((int)character < ((int)'Z' - 5))
                        {
                            result += (char)((int)character + 5);
                        }
                        else
                        {
                            result += (char)(5 - ((int)'Z' - (int)character) + (int)'A');
                        }
                    }
                }
                if (Numbers.Contains(character))
                {
                    if ((int)character <= ((int)'9' - 5))
                    {
                        result +=  (char)((int)character + 5);
                    }
                    else
                    {
                        result +=  (char)(5 - ((int)'9' - (int)character) + (int)'0');
                    }
                }
                else
                {
                    result+=character;
                }
            }
            return result;
        }
    }
}
