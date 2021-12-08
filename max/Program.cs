using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            string maxWord = "";
            int length = stringArray.Length;
            stringArray.Lengt = 0;
            for (int i = 0; i < length; i++)
            {
                if (stringArray[i].Length > max)
                {
                    max = stringArray[i].Length;
                    maxWord = stringArray[i];
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
