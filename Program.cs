using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Roman_numerals_helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter arabic number to convert it to Roman: ");
            int arabicNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Roman_Numerals_Helper.ToRoman(arabicNum));

            Console.Write("Please enter Roman number to convert it to Arabic: ");
            string romanNum = Console.ReadLine();
            Console.WriteLine(Roman_Numerals_Helper.FromRoman(romanNum));

            Console.ReadKey();
        }
    }
}
