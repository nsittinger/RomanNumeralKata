using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class CLI
    {
        private RomanNumeralModel romanNumeralModel { get; set; }

        public CLI(RomanNumeralModel romanNumeralModel)
        {
            this.romanNumeralModel = romanNumeralModel;
        }

        //public void Running()
        //{
        //    bool running = true;
        //    while (running)
        //    {
        //        running = GetStartTime();
        //    }
        //    Environment.Exit(0);
        //}

    }
}
