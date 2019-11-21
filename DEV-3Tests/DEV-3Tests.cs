using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_3;

namespace DEV_3Tests
{
    [TestClass]
    public class StringTranslatorTester
    {

        private StringTranslator stringTranslator = new StringTranslator(StringCreator.CreateFromConsole().ToLower());

        [TestMethod]
        public void TestChecksForStringEmpty()
        {
            Assert.ThrowsException<DEV_3.InvalidCharInputException>(() => string.Empty);
        }

        [TestMethod]
        public void TestCheckForForbiddenNumders()
        {
            Assert.ThrowsException<DEV_3.InvalidCharInputException>(() => "fhsdj4jv");
        }

        [TestMethod]
        public void TestCheckForForbiddenChars()
        {
            Assert.ThrowsException<DEV_3.InvalidCharInputException>(() => "fhsdj.jv");
        
        }
    }
}

