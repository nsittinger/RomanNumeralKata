using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals_TDD
{
    [TestClass]
    public class RomanNumerals_UnitTests
    {

        RomanNumeralModel romanNumerals = new RomanNumeralModel();

        [TestMethod]
        public void IfNumberIsOneDigitTest()
        {
            Assert.AreEqual("VIII", romanNumerals.ConvertSingleDigitToRomanNumerals(8));
            Assert.AreEqual("V", romanNumerals.ConvertSingleDigitToRomanNumerals(5));
            Assert.AreEqual("III", romanNumerals.ConvertSingleDigitToRomanNumerals(3));

        }
    }
}
