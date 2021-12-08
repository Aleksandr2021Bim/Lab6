using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int max = 0;
            string resultString = "";
            int length = stringArray.Length;
            for (int i = 0; i < length; i++)
            {
                if ((stringArray[i].Length > max))
                {
                    max = stringArray[i].Length;
                    resultString = stringArray[i];
                }
                
            }
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
