using System.Linq;
using NUnit.Framework;

namespace RomanNumerals.Tests
{
    /// <summary>
    ///     Add roman numerals, works up to total of 39
    /// </summary>
    [TestFixture]
    internal class Tests
    {
        private static readonly string testNumeral = "LXXXIX";
        private static readonly int testNumeric = 89;

        [Test]
        public void Generate50Is()
        {
            var iString = Numerals.IGenerator(50);
            var result = iString.Where(a => a != 'I').ToList();
            Assert.That(result.Count == 0, Is.True);
        }

        [Test]
        public void Generate50Letters()
        {
            Assert.That(Numerals.IGenerator(50).Length == 50, Is.True);
        }

        [Test]
        public void IaddIequalsII()
        {
            Assert.That(Numerals.Addition("I", "I") == "II", Is.True);
        }

        [Test]
        public void IIaddIequals()
        {
            Assert.That(Numerals.Addition("II", "I") == "III", Is.True);
        }

        [Test]
        public void IIaddVequalsVII()
        {
            Assert.That(Numerals.Addition("II", "V") == "VII", Is.True);
        }

        [Test]
        public void IIIaddIequalsIV()
        {
            Assert.That(Numerals.Addition("III", "I") == "IV", Is.True);
        }

        [Test]
        public void IVaddIequalsV()
        {
            Assert.That(Numerals.Addition("IV", "I") == "V", Is.True);
        }

        [Test]
        public void LIVaddXXXVequalsLXXXIX() /*54+35*/
        {
            Assert.That(Numerals.Addition("LIV", "XXXV") == "LXXXIX", Is.True);
        }

        [Test]
        public void LXXXIXaddXIequalsC() /*89+11*/
        {
            Assert.That(Numerals.Addition("LXXXIX", "XI") == "C", Is.True);
        }

        [Test]
        public void TranslateItoNumeral()
        {
            var translateOutput = Numerals.IGenerator(testNumeric);
            foreach (var translation in Numerals.TranslateFromI())
            {
                translateOutput = translateOutput.Replace(translation.Key, translation.Value);
            }
            Assert.That(translateOutput == testNumeral, Is.True);
        }

        [Test]
        public void TranslateNumeralToI()
        {
            var result = Numerals.TranslateInput(testNumeral);
            Assert.That(result == Numerals.IGenerator(testNumeric), result.Length.ToString());
        }

        [Test]
        public void VaddIIequalsVII()
        {
            Assert.That(Numerals.Addition("V", "II") == "VII", Is.True);
        }

        [Test]
        public void VIIIaddIequalsIX()
        {
            Assert.That(Numerals.Addition("VIII", "I") == "IX", Is.True);
        }

        [Test]
        public void XIXaddXequalsXXIX()
        {
            Assert.That(Numerals.Addition("XIX", "X") == "XXIX", Is.True);
        }

        [Test]
        public void XXXIIIaddVIequalsXXXIX() /*33+6*/
        {
            Assert.That(Numerals.Addition("XXXIII", "VI") == "XXXIX", Is.True);
        }

        [Test]
        public void XXXIIIaddVIIequalsXL() /*33+7*/
        {
            Assert.That(Numerals.Addition("XXXIII", "VII") == "XL", Is.True);
        }

        [Test]
        public void XXXIIIaddVIIIequalsXLI() /*33+8*/
        {
            Assert.That(Numerals.Addition("XXXIII", "VIII") == "XLI", Is.True);
        }
    }
}