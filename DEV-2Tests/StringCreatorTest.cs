using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2;

namespace DEV_2Tests
{
    [TestClass]
    public class StringCreatorTest
    {
        [TestMethod]
        public void StringContainsOnlyLetter()
        {
            string beginningString = "a";
            int getMaxNumberOfDifferentConsecutiveChar = 1;
            
            int maxChars = StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString);
            Assert.AreEqual(getMaxNumberOfDifferentConsecutiveChar, maxChars, "Method GetMaxNumberOfDifferentConsecutiveChar doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveDigits = 0;

            int maxDigitals = StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveDigits, maxDigitals, "Method GetMaxNumberOfIdenticalConsecutiveDigits doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveLetter = 1;

            int maxLetters = StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveLetter, maxLetters, "Method GetMaxNumberOfIdenticalConsecutiveLetter doesn't work correctly");
        }
        [TestMethod]
        public void StringContainsOnlyLetters()
        {
            string beginningString = "adffhhhhklmbz";
            int getMaxNumberOfDifferentConsecutiveChar = 6;

            int maxChars = StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString);
            Assert.AreEqual(getMaxNumberOfDifferentConsecutiveChar, maxChars, "Method GetMaxNumberOfDifferentConsecutiveChar doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveDigits = 0;

            int maxDigitals = StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveDigits, maxDigitals, "Method GetMaxNumberOfIdenticalConsecutiveDigits doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveLetter = 4;

            int maxLetters = StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveLetter, maxLetters, "Method GetMaxNumberOfIdenticalConsecutiveLetter doesn't work correctly");
        }

        [TestMethod]
        public void StringContainsOnlyNumber()
        {
            string beginningString = "9";
            int getMaxNumberOfDifferentConsecutiveChar = 1;

            int maxChars = StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString);
            Assert.AreEqual(getMaxNumberOfDifferentConsecutiveChar, maxChars, "Method GetMaxNumberOfDifferentConsecutiveChar doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveDigits = 1;

            int maxDigitals = StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveDigits, maxDigitals, "Method GetMaxNumberOfIdenticalConsecutiveDigits doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveLetter = 0;

            int maxLetters = StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveLetter, maxLetters, "Method GetMaxNumberOfIdenticalConsecutiveLetter doesn't work correctly");
        }
        [TestMethod]
        public void StringContainsOnlyNumbers()
        {
            string beginningString = "94566623555580";
            int getMaxNumberOfDifferentConsecutiveChar = 4;

            int maxChars = StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString);
            Assert.AreEqual(getMaxNumberOfDifferentConsecutiveChar, maxChars, "Method GetMaxNumberOfDifferentConsecutiveChar doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveDigits = 4;

            int maxDigitals = StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveDigits, maxDigitals, "Method GetMaxNumberOfIdenticalConsecutiveDigits doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveLetter = 0;

            int maxLetters = StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveLetter, maxLetters, "Method GetMaxNumberOfIdenticalConsecutiveLetter doesn't work correctly");
        }
        [TestMethod]
        public void StringContainsLettersAndNumbers()
        {
            string beginningString = "aZcck53aaAc66f";
            int getMaxNumberOfDifferentConsecutiveChar = 5;

            int maxChars = StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString);
            Assert.AreEqual(getMaxNumberOfDifferentConsecutiveChar, maxChars, "Method GetMaxNumberOfDifferentConsecutiveChar doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveDigits = 2;

            int maxDigitals = StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveDigits, maxDigitals, "Method GetMaxNumberOfIdenticalConsecutiveDigits doesn't work correctly");
            int getMaxNumberOfIdenticalConsecutiveLetter = 2;

            int maxLetters = StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString);
            Assert.AreEqual(getMaxNumberOfIdenticalConsecutiveLetter, maxLetters, "Method GetMaxNumberOfIdenticalConsecutiveLetter doesn't work correctly");
        }

        [TestMethod]
        public void StringIsEmpty()
        {
            string beginningString = "";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString)) ;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString));
        }
        [TestMethod]
        public void StringContainsIllegalCharBoundaryConditionOne()
        {
            string beginningString = "afg/jb";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString));
        }
        [TestMethod]
        public void StringContainsIllegalCharBoundaryConditionTwo()
        {
            string beginningString = "af:gjb";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString));
        }
        [TestMethod]
        public void StringContainsIllegalCharBoundaryConditionThree()
        {
            string beginningString = "afgjb@";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString));
        }
        [TestMethod]
        public void StringContainsIllegalCharBoundaryConditionFour()
        {
            string beginningString = "[afgjb";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString));
        }
        [TestMethod]
        public void StringContainsIllegalCharBoundaryConditionFive()
        {
            string beginningString = "'afgjb";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString));
        }
        [TestMethod]
        public void StringContainsIllegalCharBoundaryConditionSix()
        {
            string beginningString = "{";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfDifferentConsecutiveChar(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(beginningString));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(beginningString));
        }
        

    }
}
