using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

[TestFixture]

    public class FizzBuzzTests
    {
    
    [TestCase(1,"1")]
    [TestCase(2, "2")]
    [TestCase(3, "Bizz")]
    [TestCase(6, "Bizz")]
    [TestCase(9, "Bizz")]
    [TestCase(10, "Buzz")]
    [TestCase(15, "BizzBuzz")]
    [TestCase(20, "Buzz")]
    
    public void Translate(int input, string expected)
    {
        Assert.That(Translator.Translate(input), Is.EqualTo(expected));
       
    }
    /*
    [TestCase(21, "Buzz")]
    public void Translate2(int input, string expected)
    {
        Assert.That(Translator.Translate(2), Is.EqualTo(expected));

    }*/
    public class Translator
    {
        public static string Translate(int i)
        {
            if (ShouldFizz(i) && ShouldBuzz(i)) return "BizzBuzz";
            if (ShouldFizz(i)) return "Bizz"; 
            return ShouldBuzz(i) ? "Buzz" : i.ToString();
        }

        private static bool ShouldBuzz(int s)
        {
            return s%5 == 0;
        }

        private static bool ShouldFizz(int s)
        {
            return s%3 == 0;
        }
    }
}

