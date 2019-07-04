using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    class Test
    {
        [TestCase("ab-cd", "dc-ba")]
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [TestCase("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]

        public static void TestRevMethod(string input, string expected)
        {
            string current = StringProblem.reverse(input);

            Assert.AreEqual(expected, current);
        }
    }
}
