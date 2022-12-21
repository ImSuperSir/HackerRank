

using HackerRank;
using System.ComponentModel.DataAnnotations;

namespace CountBinarySubstringsTest
{
    public class StringTests
    {

        [Theory]
        //[InlineData("abba", "String Empty")]
        //[InlineData("a", "a")]
        //[InlineData("ba", "ba")]
        [InlineData("aaabccddd", "abd")]
        public void SuperReducedStringTest(string pCadena, string pExpected)
        {
            var lResult = SuperReducedString.Reduce(pCadena);

            Assert.Equal(pExpected, lResult);
        }

        [Theory]
        [InlineData("lauroRamirez", 2)]
        public void CuentaPalabrasCamelCase(string pCamelCaseWords, int pExcpectedWords)
        {
            var lResult = CamelCase.Test(pCamelCaseWords);
            Assert.Equal(pExcpectedWords, lResult);
        }

        //[Fact]
        //public void PasswordStrongTest()
        //{

        //    char[] lcharArray = "0123456789".ToCharArray();
        //    var lResult = StringPassword.AddCharArrayToHashSet(lcharArray);

        //    Assert.Equal(10, lResult.Count);


        //}

        [Theory]
        [InlineData("2bbb",2)]
        [InlineData("Ab1", 3)]
        public void PasswordStrongTest(string pPassword, int pExpected)
        {

            var lResult = StringPassword.Test(pPassword.Length, pPassword);

            Assert.Equal(pExpected, lResult);


        }
    }
}
