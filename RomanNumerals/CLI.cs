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

        public void Running()
        {
            bool running = true;
            while (running)
            {
                running = PromptForNumber();
            }
            Environment.Exit(0);
        }

        public bool PromptForNumber()
        {
            
            Console.WriteLine("Please insert a number. (Max 4 digits)");
            int input = Convert.ToInt32(Console.ReadLine());

            bool running = true;
            while(running)
            {
                running = NumberToRomanNumeralMethod(input);
            }

            return running;
        }

        public bool NumberToRomanNumeralMethod(int input)
        {
            string romanNumeralOutput = romanNumeralModel.ConvertNumbersToRomanNumerals(input);
            bool correctNumberOfDigits = romanNumeralModel.ConfirmCorrectNumberOfDigits(input);

            bool running = true;

            if(correctNumberOfDigits)
            {
                Console.WriteLine();
                Console.WriteLine(input + " in Roman Numerals is " + romanNumeralOutput);
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect number input");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            while (running)
            {
                running = RepeatMenu();
            }

            return running;
        }

        public bool RepeatMenu()
        {
            bool running = true;

            Console.WriteLine("Repeat calculation? (y/n)");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                running = PromptForNumber();
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            return running;
        }
    }
}
