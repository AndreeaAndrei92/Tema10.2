using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    [TestFixture]
    class Test
    {
        [TestCase(2, 1, 3)]
        [TestCase(19, 20, 39)]
        [TestCase(2.3, 1.6, 3.9)]
        [TestCase(99, 1, 100)]
        public static void TestAdd(double a, double b, double expected)
        {
            Assert.AreEqual(Calculator.Add(a, b), expected);
        }

        [TestCase(7, 5, 2)]
        [TestCase(23, 50, -27)]
        [TestCase(2.3, 1.6, 0.7)]
        [TestCase(99, 99, 0)]
        public static void TestSub(double a, double b, double expected)
        {
            Assert.AreEqual(Calculator.Sub(a, b), expected);
        }

        [TestCase(1, 1, 1)]
        [TestCase(23, 50, 1150)]
        [TestCase(2.3, 1.6, 3.68)]
        [TestCase(-2, 9, -18)]
        public static void TestMul(double a, double b, double expected)
        {
            Assert.AreEqual(Calculator.Mul(a, b), expected);
        }

        [TestCase(1, 1, 1)]
        [TestCase(23, 50, 0.46)]
        [TestCase(2.3, 1.6, 1.4375)]
        [TestCase(10, 2, 5)]
        public static void TestDiv(double a, double b, double expected)
        {
            Assert.AreEqual(Calculator.Div(a, b), expected);
        }
    }
}

