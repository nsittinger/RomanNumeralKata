using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeralModel romanNumeralModel = new RomanNumeralModel();
            CLI myCLI = new CLI(romanNumeralModel);

            myCLI.Running();
        }
    }
}
