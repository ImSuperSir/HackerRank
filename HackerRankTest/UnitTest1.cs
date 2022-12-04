

using HackerRank;

namespace CountBinarySubstringsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1100111000",7)]
        [InlineData("1100", 2)]
        [InlineData("110011", 4)]
        [InlineData("10101", 4)]
        [InlineData("00110011", 6)]
        public void CountBinarySubstringsGrouped(string pCadena, int pExpected)
        {

            CountBinarySubstrings l = new CountBinarySubstrings();
            var lResult = l.Count(pCadena);

            Assert.Equal(pExpected, lResult);
        }
    }
}