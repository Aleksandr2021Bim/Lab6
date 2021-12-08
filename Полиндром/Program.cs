using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полиндром
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую инженер \nвведите текст и проверьте палиндром");
            string startString = Console.ReadLine();
            // string S = startString;
            // string[] stringArray = startString.Split();
            bool f = true;
            int length = startString.Length;
            for (int i = 1, j = length - 1; i < j; i++, j--)
                if (startString[i] != startString[j])
                    f = false;
            if (f)
                    Console.WriteLine("Эта строка - палиндром", startString);
            else 
                    Console.WriteLine("Эта строка - не палиндром", startString);
            Console.ReadLine();
        }
    }
}
