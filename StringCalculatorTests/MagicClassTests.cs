using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    public class MagicClassTests
    {
        [Test]
        public void WhenMagicIsCreated_MagicHappens()
        {
            var sut = new MagicClass();

            Assert.AreEqual(true, sut.ItsMagic);
        }
    }
}