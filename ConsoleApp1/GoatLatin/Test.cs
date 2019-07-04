using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    [TestFixture]
    class Test
    {
        [TestCase("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]

        [TestCase("The quick brown fox jumped over the lazy dog",
    "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]

        public static void TestGoatLatin(string input, string expected)
        {
            Assert.AreEqual(GoatLatin.GoatLatinn(input), expected);
        }
    }
}

