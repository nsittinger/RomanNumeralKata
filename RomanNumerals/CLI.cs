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
            
            Console.WriteLine("Please insert a positive number! Either Roman or Arabic Numerals! (Max: 3000)");
            string stringInput = Console.ReadLine();
            int intInput = 0;
            bool isNumber = int.TryParse(stringInput, out intInput);

            bool running = true;
            while(running)
            {
                if (isNumber == false)
                {
                    running = RomanNumeralToNumberMethod(stringInput);
                }
                else
                {
                    running = NumberToRomanNumeralMethod(intInput);
                }
            }

            return running;
        }

        public bool RomanNumeralToNumberMethod(string input)
        {
            bool running = true;
            int arabicNumeralOutput = romanNumeralModel.ConvertoRomanNumeralsToNumbers(input);
            bool correctNumberOfDigits = romanNumeralModel.ConfirmCorrectNumberOfDigits(arabicNumeralOutput);

            if (!correctNumberOfDigits)
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect number input");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(input.ToUpper() + " in Arabic Numerals is " + arabicNumeralOutput);
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

        public bool NumberToRomanNumeralMethod(int input)
        {
            bool correctNumberOfDigits = romanNumeralModel.ConfirmCorrectNumberOfDigits(input);
            
            bool running = true;
            
            if (!correctNumberOfDigits)
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect number input");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                string romanNumeralOutput = romanNumeralModel.ConvertNumbersToRomanNumerals(input);
                Console.WriteLine();
                Console.WriteLine(input + " in Roman Numerals is " + romanNumeralOutput);
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

            Console.WriteLine("Try Again? (y/n)");
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
