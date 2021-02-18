using NUnit.Framework;
using CodingKata;

namespace CodingKata
{
    public class StringCalculatorTests
    {
        [Test]
        public void WhenMagicIsCreated_MagicHappens()
        {
            Assert.DoesNotThrow(() => _ = new StringCalculator());
        }
    }
}