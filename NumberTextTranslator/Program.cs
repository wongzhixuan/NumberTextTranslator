using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTextTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number to be translated to text: ");
                string numberStr = Console.ReadLine();
                int total = calculateWaysOfTranslations(numberStr);
                Console.WriteLine($"Total ways: {total}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static int calculateWaysOfTranslations(string numString)
        {
            int prevCount = 0;
            int currCount = 1;
            for (int i = 1; i <= numString.Length; i++)
            {
                int newCount = 0;
                if (numString[i-1] != '0')
                {
                    newCount = currCount;
                }
                if (i > 1 && (numString[i-2] == '1' || (numString[i-2] == '2' && numString[i-1] <= '6')))
                {
                    newCount += prevCount;
                }

                prevCount = currCount;
                currCount = newCount;
            }

            return currCount;
        }
    }
}
