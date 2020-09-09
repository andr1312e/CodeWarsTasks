using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "  ... --- ...     ";
            Console.WriteLine(Decode(input));
            Console.ReadKey();
        }

        public static string Decode(string morseCode)
        {
            char dot = '.';
            char dush = '-';
            morseCode=morseCode.TrimStart();
            morseCode = morseCode.TrimEnd();
            morseCode += " ";
            morseCode.ToUpper();
            Dictionary<char[], char> MorceDictonary = new Dictionary<char[], char>(new charArrayComparer());
            MorceDictonary.Add(new char[] { dot, dush }, 'A');
            MorceDictonary.Add(new char[] { dush, dot, dot, dot }, 'B');
            MorceDictonary.Add(new char[] { dush, dot, dush, dot }, 'C');
            MorceDictonary.Add(new char[] { dush, dot, dot }, 'D');
            MorceDictonary.Add(new char[] { dot }, 'E');
            MorceDictonary.Add(new char[] { dot, dot, dush, dot }, 'F');
            MorceDictonary.Add(new char[] { dush, dush, dot }, 'G');
            MorceDictonary.Add(new char[] { dot, dot, dot, dot }, 'H');
            MorceDictonary.Add(new char[] { dot, dot }, 'I');
            MorceDictonary.Add(new char[] { dot, dush, dush, dush }, 'J');
            MorceDictonary.Add(new char[] { dush, dot, dush }, 'K');
            MorceDictonary.Add(new char[] { dot, dush, dot, dot }, 'L');
            MorceDictonary.Add(new char[] { dush, dush }, 'M');
            MorceDictonary.Add(new char[] { dush, dot }, 'N');
            MorceDictonary.Add(new char[] { dush, dush, dush }, 'O');
            MorceDictonary.Add(new char[] { dot, dush, dush, dot }, 'P');
            MorceDictonary.Add(new char[] { dush, dush, dot, dush }, 'Q');
            MorceDictonary.Add(new char[] { dot, dush, dot }, 'R');
            MorceDictonary.Add(new char[] { dot, dot, dot }, 'S');
            MorceDictonary.Add(new char[] { dush }, 'T');
            MorceDictonary.Add(new char[] { dot, dot, dush }, 'U');
            MorceDictonary.Add(new char[] { dot, dot, dot, dush }, 'V');
            MorceDictonary.Add(new char[] { dot, dush, dush }, 'W');
            MorceDictonary.Add(new char[] { dush, dot, dot, dush }, 'X');
            MorceDictonary.Add(new char[] { dush, dot, dush, dush }, 'Y');
            MorceDictonary.Add(new char[] { dush, dush, dot, dot }, 'Z');
            MorceDictonary.Add(new char[] { dot, dush, dush, dush, dush }, '1');
            MorceDictonary.Add(new char[] { dot, dot, dush, dush }, '2');
            MorceDictonary.Add(new char[] { dot, dot, dot, dush, dush }, '3');
            MorceDictonary.Add(new char[] { dot, dot, dot, dot, dush }, '4');
            MorceDictonary.Add(new char[] { dot, dot, dot, dot, dot }, '5');
            MorceDictonary.Add(new char[] { dush, dot, dot, dot, dot }, '6');
            MorceDictonary.Add(new char[] { dush, dush, dot, dot, dot }, '7');
            MorceDictonary.Add(new char[] { dush, dush, dush, dot, dot }, '8');
            MorceDictonary.Add(new char[] { dush, dush, dush, dush, dot }, '9');
            MorceDictonary.Add(new char[] { dush, dush, dush, dush, dush }, '0');
            string resultText = string.Empty;
            string currentCharecter = string.Empty;
            int NumOfSpaces = 0;
            foreach (var sybmol in morseCode)
            {
                if (sybmol != ' ')
                {
                    currentCharecter += sybmol;
                    NumOfSpaces = 0;

                }
                else
                {
                    NumOfSpaces++;
                    var array = currentCharecter.ToCharArray();

                    if (MorceDictonary.ContainsKey(array))
                    {
                        resultText += MorceDictonary[currentCharecter.ToCharArray()];

                        currentCharecter = string.Empty;
                        Console.WriteLine("good");
                    }
                    if (NumOfSpaces == 3)
                    {
                        resultText += " ";
                    }

                }
            }
            return resultText;
        }
    }
    class charArrayComparer : IEqualityComparer<char[]>
    {
        public bool Equals(char[] x, char[] y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(char[] obj)
        {
            return this.GetHashCode();
        }
    }
}
