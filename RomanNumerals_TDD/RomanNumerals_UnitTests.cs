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

        [TestMethod]
        public void IfNumberIsTwoDigitsTest()
        {
            Assert.AreEqual("X", romanNumerals.ConvertDoubleDigitToRomanNumerals(10));

            Assert.AreEqual("XIV", romanNumerals.ConvertDoubleDigitToRomanNumerals(14));

            Assert.AreEqual("XL", romanNumerals.ConvertDoubleDigitToRomanNumerals(40));
        }

        [TestMethod]
        public void IfNumberIsThreeDigitsTest()
        {
            Assert.AreEqual("CDXLVIII", romanNumerals.ConvertTripleDigitToRomanNumerals(448));
            Assert.AreEqual("DII", romanNumerals.ConvertTripleDigitToRomanNumerals(502));
            Assert.AreEqual("CXIV", romanNumerals.ConvertTripleDigitToRomanNumerals(114));
        }
    }
}
