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
            Assert.AreEqual("X", romanNumerals.ConvertDoubleDigitsToRomanNumerals(10));

            Assert.AreEqual("XIV", romanNumerals.ConvertDoubleDigitsToRomanNumerals(14));

            Assert.AreEqual("XL", romanNumerals.ConvertDoubleDigitsToRomanNumerals(40));
        }

        [TestMethod]
        public void IfNumberIsThreeDigitsTest()
        {
            Assert.AreEqual("CDXLVIII", romanNumerals.ConvertTripleDigitsToRomanNumerals(448));
            Assert.AreEqual("DII", romanNumerals.ConvertTripleDigitsToRomanNumerals(502));
            Assert.AreEqual("CXIV", romanNumerals.ConvertTripleDigitsToRomanNumerals(114));
        }

        [TestMethod]
        public void IfNumberIsFourDigitsTest()
        {
            Assert.AreEqual("MCDXIV", romanNumerals.ConvertQuadrupalDigitsToRomanNumerals(1414));
            Assert.AreEqual("MCCVI", romanNumerals.ConvertQuadrupalDigitsToRomanNumerals(1206));
            Assert.AreEqual("MCXXII", romanNumerals.ConvertQuadrupalDigitsToRomanNumerals(1122));
        }
    }
}
