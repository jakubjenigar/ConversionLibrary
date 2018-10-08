using ConversionLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void toOunceTest()
        {
            ConversionMethods conversionTest = new ConversionMethods();
            double result = conversionTest.toOunces(15);
            Assert.AreEqual(0.52910942924, result, 0.001);
        }

        [TestMethod]
        public void toGramTest()
        {
            ConversionMethods conversionTest = new ConversionMethods();
            double result = conversionTest.toGrams(15);
            Assert.AreEqual(425.2428, result, 0.001);
        }
    }
}
