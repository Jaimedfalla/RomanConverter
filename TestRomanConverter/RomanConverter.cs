using ConversorRomanos;
namespace TestRomanConverter
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(8, "VIII")]
        [TestCase(80, "LXXX")]
        [TestCase(90, "XC")]
        [TestCase(91, "XCI")]
        [TestCase(264, "CCLXIV")]
        [TestCase(2008, "MMVIII")]
        [TestCase(2014, "MMXIV")]
        public void Test_Decimal_To_Roman_Number_Success(int number, string expected)
        {
            string converted = RomanConverter.ConvertNumber(number);
            Assert.That(converted, Is.EqualTo(expected));
        }
    }
}