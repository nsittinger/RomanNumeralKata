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
            Assert.AreEqual("VIII", romanNumerals.ConvertNumbersToRomanNumerals(8));
            Assert.AreEqual("V", romanNumerals.ConvertNumbersToRomanNumerals(5));
            Assert.AreEqual("III", romanNumerals.ConvertNumbersToRomanNumerals(3));
        }

        [TestMethod]
        public void IfNumberIsTwoDigitsTest()
        {
            Assert.AreEqual("X", romanNumerals.ConvertNumbersToRomanNumerals(10));
            Assert.AreEqual("XIV", romanNumerals.ConvertNumbersToRomanNumerals(14));
            Assert.AreEqual("XL", romanNumerals.ConvertNumbersToRomanNumerals(40));
        }

        [TestMethod]
        public void IfNumberIsThreeDigitsTest()
        {
            Assert.AreEqual("CDXLVIII", romanNumerals.ConvertNumbersToRomanNumerals(448));
            Assert.AreEqual("DII", romanNumerals.ConvertNumbersToRomanNumerals(502));
            Assert.AreEqual("CXIV", romanNumerals.ConvertNumbersToRomanNumerals(114));
        }

        [TestMethod]
        public void IfNumberIsFourDigitsTest()
        {
            Assert.AreEqual("MCDXIV", romanNumerals.ConvertNumbersToRomanNumerals(1414));
            Assert.AreEqual("MCCVI", romanNumerals.ConvertNumbersToRomanNumerals(1206));
            Assert.AreEqual("MCXXII", romanNumerals.ConvertNumbersToRomanNumerals(1122));
        }

        [TestMethod]
        public void ConfirmLengthIsLessThanFive()
        {
            Assert.AreEqual(true, romanNumerals.ConfirmCorrectNumberOfDigits(123));
            Assert.AreEqual(false, romanNumerals.ConfirmCorrectNumberOfDigits(12345));
        }

        [TestMethod]
        public void ConfirmRomanNumeralToNumberSingleDigit()
        {
            Assert.AreEqual(5, romanNumerals.ConvertoRomanNumeralsToNumbers("V"));
            Assert.AreEqual(7, romanNumerals.ConvertoRomanNumeralsToNumbers("VII"));
        }

        [TestMethod]
        public void ConfirmRomanNumeralToNumberDoubleDigits()
        {
            Assert.AreEqual(10, romanNumerals.ConvertoRomanNumeralsToNumbers("X"));
            Assert.AreEqual(14, romanNumerals.ConvertoRomanNumeralsToNumbers("XIV"));
        }

        [TestMethod]
        public void ConfirmRomanNumeralToNumberTripleDigits()
        {
            Assert.AreEqual(448, romanNumerals.ConvertoRomanNumeralsToNumbers("CDXLVIII"));
            Assert.AreEqual(900, romanNumerals.ConvertoRomanNumeralsToNumbers("CM"));
        }
    }
}
