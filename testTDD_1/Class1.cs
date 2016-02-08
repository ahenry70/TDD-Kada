using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace testTDD_1
{

    [TestFixture]
    public class testMultiplication
{
        [Test]
        public void Test_Multiplication()
        {
            var five = new Dollar(5);
            Dollar product = five.Times(2);
            
            Assert.AreEqual(10, product.Amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.Amount);

        }

}
    public class Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public Dollar Times(int Multiplier)
        {
            return new Dollar(Amount * Multiplier);
        }

        
    }
}
