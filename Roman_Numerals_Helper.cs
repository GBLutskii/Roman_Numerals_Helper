using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Roman_numerals_helper
{
    internal class Roman_Numerals_Helper
    {
        // function Arabic to Roman 
        static string ArabicToRoman(int arabicNum)
        {
            string result = "";
            char one, five, dozen;
            int myNum = new int();
            string tempStr;

            if (arabicNum >= 100) { myNum = arabicNum / 100; one = 'C'; five = 'D'; dozen = 'M'; }
            else if (arabicNum >= 10) { myNum = arabicNum / 10; one = 'X'; five = 'L'; dozen = 'C'; }
            else { myNum = arabicNum; one = 'I'; five = 'V'; dozen = 'X'; }

            if (myNum == 9) { result += one; result += dozen; }
            else if (myNum >= 5)
            {
                result += five;
                myNum -= 5;
                tempStr = new String(one, myNum);
                result += tempStr;
            }
            else if (myNum == 4) { result += one; result += five; }
            else { tempStr = new string(one, myNum); result += tempStr; }

            return result;
        }

        // body Arabic to Roman
        public static string ToRoman(int n)
        {
            string result = "";

            int unos = n % 10;
            int dozens = (n % 100) - unos;
            int hundreds = (n % 1000) - unos - dozens;
            int thousands = n - unos - dozens - hundreds;

            if (thousands >= 1000)
            {
                string tempStr = new String('M', (thousands / 1000));
                result += tempStr;
            }

            result += ArabicToRoman(hundreds) + ArabicToRoman(dozens) + ArabicToRoman(unos);

            return result;
        }

        // function Roman to Arabic
        static int RomanToArabic(char romDigit)
        {
            int result = new int();
            switch (romDigit)
            {
                case 'I':
                    result = 1;
                    break;
                case 'V':
                    result = 5;
                    break;
                case 'X':
                    result = 10;
                    break;
                case 'L':
                    result = 50;
                    break;
                case 'C':
                    result = 100;
                    break;
                case 'D':
                    result = 500;
                    break;
                case 'M':
                    result = 1000;
                    break;
            }
            return result;
        }

        // body Roman to Arabic
        public static int FromRoman(string romanNumeral)
        {
            char[] tempArray = romanNumeral.ToCharArray();
            Array.Reverse(tempArray);
            string reversedRomNum = new string(tempArray);

            int tempNum = 0;
            int currentNum = new int();
            int result = 0;

            foreach (char c in reversedRomNum)
            {
                currentNum = RomanToArabic(c);

                if (currentNum >= tempNum) { result += currentNum; }
                else { result -= currentNum; }

                tempNum = currentNum;
            }

            return result;
        }
    }
}
