using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDD_Kada_BizzBuzz
{
    [TestFixture]

    public class FizzBuzzTest
    {
        /*[Test]
        public void Translate1()
        {
        Assert.That(Translator.Translate(1), Is.EqualTo("1"));
        Assert.That(Translator.Translate(2), Is.EqualTo("2"));
        Assert.That(Translator.Translate(3), Is.EqualTo("Fizz"));
        Assert.That(Translator.Translate(5), Is.EqualTo("Buzz"));
        }*/

        [TestCase (1,"1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]

        public void TranslateCase(int result, string expected)
        {
            Assert.That(Translator.Translate(result), Is.EqualTo(expected));
        }
    }

    public class Translator
    {
        internal static string Translate(int v)
        {
            var ResultString = "";
            if (isFizz(v)) ResultString += "Fizz";
            if (isBuzz(v)) ResultString += "Buzz";
            if (string.IsNullOrEmpty(ResultString)) ResultString += v.ToString();
            return ResultString;
        }

        private static bool isFizz(int v)
        {
            return v%3 == 0;
        }
        private static bool isBuzz(int v)
        {
            return v % 5 == 0;
        }
    }
}
