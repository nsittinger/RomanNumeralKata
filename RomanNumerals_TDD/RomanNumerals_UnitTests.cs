﻿using System;
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
    }
}
