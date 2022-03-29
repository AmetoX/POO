using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nr.Rationale_03._29_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr.Rationale_03._29_.Tests
{
    [TestClass()]
    public class RationalTests
    {
        [TestMethod()]
        public void RationalTest()
        {
            //arrange
            Rational r = new Rational(-1, 2);

            //act
            Sign acctual = r.Semn;
            Sign expected = Sign.Negativ;

            //assert
            Assert.AreEqual(expected, acctual);
        }
        [TestMethod()]
        public void RationalTestPoz()
        {
            //arrange
            Rational r = new Rational(1, 2);

            //act
            Sign acctual = r.Semn;
            Sign expected = Sign.Pozitiv;

            //assert
            Assert.AreEqual(expected, acctual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //arrange 
            Rational r =new Rational(1,2);

            //act
            string actual = r.ToString();
            string expected = "(1 / 2)";

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}