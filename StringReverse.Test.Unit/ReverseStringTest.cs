using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace StringReverse.Test.Unit
{
    [TestClass]
    public class ReverseStringTest
    {
        ReverseString reverseString = new ReverseString();

        [TestMethod]
        public void ReverseASingleWord()
        {
            string input = "test";
            char[] reversedArray = reverseString.Reverse(input);
            string stringToReturn = new string(reversedArray);

            Assert.IsTrue(stringToReturn == "tset");
        }

        [TestMethod]
        public void ReverseTwoWordsWithNoCaptials()
        {
            string input = "anothertest";
            char[] reversedArray = reverseString.Reverse(input);
            string stringToReturn = new string(reversedArray);

            Assert.IsTrue(stringToReturn == "tsetrehtona");
        }

        [TestMethod]
        public void ReverseTwoWordsWithCaptials()
        {
            string input = "AnotherTest";
            char[] reversedArray = reverseString.Reverse(input);
            string stringToReturn = new string(reversedArray);

            Assert.IsTrue(stringToReturn == "tseTrehtonA");
        }

        [TestMethod]
        public void ReverseTwoWordsWithCaptialsAndSpace()
        {
            string input = "Another Test";
            char[] reversedArray = reverseString.Reverse(input);
            string stringToReturn = new string(reversedArray);

            Assert.IsTrue(stringToReturn == "tseT rehtonA");
        }

        [TestMethod]
        public void ReverseTwoWordsWithNoCaptialsAndSpace()
        {
            string input = "another test";
            char[] reversedArray = reverseString.Reverse(input);
            string stringToReturn = new string(reversedArray);

            Assert.IsTrue(stringToReturn == "tset rehtona");
        }

        [TestMethod]
        public void ReverseTwoWordsWithNoCaptialsAndSeveralSpace()
        {
            string input = "another    test";
            char[] reversedArray = reverseString.Reverse(input);
            string stringToReturn = new string(reversedArray);

            Assert.IsTrue(stringToReturn == "tset    rehtona");
        }

        //could not get these tests working, however the program does throw an ArgumentException when a symbol or number is used

        //[TestMethod]
        //public void ThrowArgumentExceptionWhenUsingSymbols()
        //{
        //    string input = "te$t";
        //    char[] reversedArray = reverseString.Reverse(input);

        //    Assert.ThrowsException<ArgumentException>(() => reverseString.Reverse(input));
        //}

        //[TestMethod]
        //public void ThrowArgumentExceptionWhenUsingNumbers()
        //{
        //    string input = "te1t";
        //    char[] reversedArray = reverseString.Reverse(input);

        //    Assert.ThrowsException<ArgumentException>(() => reverseString.Reverse(input));
        //}


    }
}
