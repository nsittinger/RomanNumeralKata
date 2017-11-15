using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralModel
    {
        Dictionary<int, string> newDictionary = new Dictionary<int, string>()
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

                result += newDictionary[nFirstIndex];
            }

            else if(nString.Length == 2)
            {
                int nFirstIndex = int.Parse(nString[0].ToString()) * 10;

                result += newDictionary[nFirstIndex];

                int nSecondIndex = int.Parse(nString[1].ToString());

                result += newDictionary[nSecondIndex];
            }

            else if (nString.Length == 3)
            {
                int nFirstIndex = int.Parse(nString[0].ToString()) * 100;

                result += newDictionary[nFirstIndex];

                int nSecondIndex = int.Parse(nString[1].ToString()) * 10;

                result += newDictionary[nSecondIndex];

                int nThirdIndex = int.Parse(nString[2].ToString());

                result += newDictionary[nThirdIndex];
            }

            else if (nString.Length == 4)
            {
                int nFirstIndex = int.Parse(nString[0].ToString()) * 1000;

                result += newDictionary[nFirstIndex];

                int nSecondIndex = int.Parse(nString[1].ToString()) * 100;

                result += newDictionary[nSecondIndex];

                int nThirdIndex = int.Parse(nString[2].ToString()) * 10;

                result += newDictionary[nThirdIndex];

                int nFourthIndex = int.Parse(nString[3].ToString());

                result += newDictionary[nFourthIndex];
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
