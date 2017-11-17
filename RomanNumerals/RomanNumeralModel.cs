using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralModel
    {
        //NUMBER TO ROMAN NUMERAL METHODS
        Dictionary<int, string> numberToRomanDictionary = new Dictionary<int, string>()
            {
                {0, "" },
                {1, "I" },
                {2, "II" },
                {3, "III" },
                {4, "IV" },
                {5, "V" },
                {6, "VI"},
                {7, "VII" },
                {8, "VIII" },
                {9, "IX" },
                {10, "X" },
                {20, "XX" },
                {30, "XXX" },
                {40, "XL" },
                {50, "L"},
                {60, "LX" },
                {70, "LXX" },
                {80, "LXXX" },
                {90, "XC" },
                {100, "C" },
                {200, "CC" },
                {300, "CCC" },
                {400, "CD" },
                {500, "D" },
                {600, "DC" },
                {700, "DCC" },
                {800, "DCCC" },
                {900, "CM" },
                {1000, "M" },
                {2000, "MM" },
                {3000, "MMM" }
            };
        public string ConvertNumbersToRomanNumerals(int num)
        {
            string nString = num.ToString();
            string result = "";

            if (nString.Length == 1)
            {
                int nFirstIndex = int.Parse(nString[0].ToString());

                result += numberToRomanDictionary[nFirstIndex];
            }

            else if(nString.Length == 2)
            {
                int nFirstIndex = int.Parse(nString[0].ToString()) * 10;

                result += numberToRomanDictionary[nFirstIndex];

                int nSecondIndex = int.Parse(nString[1].ToString());

                result += numberToRomanDictionary[nSecondIndex];
            }

            else if (nString.Length == 3)
            {
                int nFirstIndex = int.Parse(nString[0].ToString()) * 100;

                result += numberToRomanDictionary[nFirstIndex];

                int nSecondIndex = int.Parse(nString[1].ToString()) * 10;

                result += numberToRomanDictionary[nSecondIndex];

                int nThirdIndex = int.Parse(nString[2].ToString());

                result += numberToRomanDictionary[nThirdIndex];
            }

            else if (nString.Length == 4)
            {
                int nFirstIndex = int.Parse(nString[0].ToString()) * 1000;

                result += numberToRomanDictionary[nFirstIndex];

                int nSecondIndex = int.Parse(nString[1].ToString()) * 100;

                result += numberToRomanDictionary[nSecondIndex];

                int nThirdIndex = int.Parse(nString[2].ToString()) * 10;

                result += numberToRomanDictionary[nThirdIndex];

                int nFourthIndex = int.Parse(nString[3].ToString());

                result += numberToRomanDictionary[nFourthIndex];
            }

            return result;
        }

        //ROMAN NUMERAL TO NUMBER METHODS
        Dictionary<string, int> romanToNumberDictoinary = new Dictionary<string, int>()
            {
                {"", 0 },
                {"I", 1 },
                {"II", 2 },
                {"III", 3 },
                {"IV", 4 },
                {"V", 5 },
                {"VI", 6},
                {"VII", 7 },
                {"VIII", 8 },
                {"IX", 9 },
                {"X", 10 },
                {"XX", 20 },
                {"XXX", 30 },
                {"XL", 40 },
                {"L",50},
                {"LX", 60 },
                {"LXX", 70 },
                {"LXXX", 80 },
                {"XC", 90 },
                {"C", 100 },
                {"CC", 200 },
                {"CCC", 300 },
                {"CD", 400 },
                {"D", 500 },
                {"DC", 600 },
                {"DCC", 700 },
                {"DCCC", 800 },
                {"CM", 900 },
                {"M", 1000 },
                {"MM", 2000 },
                {"MMM", 3000 },
            };
        public int ConvertoRomanNumeralsToNumbers(string num)
        {
            int result = 0;
            num = num.ToUpper();

            if (num.Length == 1)
            {
                result = romanToNumberDictoinary[num];
            }
            if (num.Length > 1)
            {
                foreach (char x in num)
                {
                    string newString = x.ToString();
                    result += romanToNumberDictoinary[newString];
                }

                for (int i = 0; i < num.Length - 1; i++)
                {
                    if (num[i] == 'I' && num[i + 1] == 'V')
                    {
                        result -= 2;
                    }
                    if (num[i] == 'I' && num[i + 1] == 'X')
                    {
                        result -= 2;
                    }
                    if (num[i] == 'X' && num[i + 1] == 'L')
                    {
                        result -= 20;
                    }
                    if (num[i] == 'X' && num[i + 1] == 'C')
                    {
                        result -= 20;
                    }
                    if (num[i] == 'C' && num[i + 1] == 'D')
                    {
                        result -= 200;
                    }
                    if (num[i] == 'C' && num[i + 1] == 'M')
                    {
                        result -= 200;
                    }
                }
            }

            return result;
        }

        public bool ConfirmCorrectNumberOfDigits(int num)
        {
            bool pass = true;

            if(num < 1 || num > 3000)
            {
                pass = false;
            }

            return pass;
        }
    }
}
