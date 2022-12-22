

using HackerRank;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

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
        [InlineData("2bbb", 2)]
        [InlineData("Ab1", 3)]
        public void PasswordStrongTest(string pPassword, int pExpected)
        {

            var lResult = StringPassword.Test(pPassword.Length, pPassword);

            Assert.Equal(pExpected, lResult);





        }

        [Theory]
        [InlineData(73, 75)]
        [InlineData(67, 67)]
        [InlineData(38, 40)]
        [InlineData(33, 33)]
        public void GradingStudents(int pGrade, int pExpectedGrade)
        {

            int lresult = GradeRedundant.Roundit(pGrade);
            Assert.Equal(lresult, pExpectedGrade);

        }

        //[Theory]
        //[InlineData(5, 1, "2, 1, 3, 2, 4")]
        //[InlineData(5,2, "2, 1, 3, 2, 4-2, 0, 2, 0, 1")]
        //[InlineData(5, 3, "2, 1, 3, 2, 4-2, 0, 2, 0, 1-6, 2, 1, 3, 0")]
        //[InlineData(5, 4, "2, 1, 3, 2, 4-2, 0, 2, 0, 1-6, 2, 1, 3, 0-3, 1, 0, 4, 3")]
        //[InlineData(1, 1, "2")]
        //[InlineData(1, 2, "2-3")]
        //[InlineData(2, 2, "2, 1-2, 0")]
        //[InlineData(2, 3, "2, 1-2, 0-3,5")]
        //[InlineData(3, 2, "2, 1,4-2, 0,4")]
        //public void TestObtieneDimensionArrayDosDimensionesXY(int x, int y, string s)
        //{
        //    List<List<int>> lDobleDimension = new List<List<int>>();

        //    foreach (var arrayCurrent in s.Split("-"))
        //    {
        //        List<int> lUnoUniDimensional = arrayCurrent.Replace(" ", "").Split(",").Select(s => int.Parse(s)).ToList();
        //        lDobleDimension.Add(lUnoUniDimensional);
        //    }

            
        //    //List<int> lUnoUniDimensional = new List<int>() { 2, 1, 3, 2, 4 };


            
        //    var lResult = BusyBeaver.GetDimension(lDobleDimension);

        //    Assert.Equal(y, lResult.Vertical);
        //    Assert.Equal(x, lResult.Horizontal);
        //    //List<int> l2 = new List<int>() { 2, 0, 2, 0, 1 };
        //    //List<int> l3 = new List<int>() { 6, 2, 1, 3, 0 };
        //    //List<int> l4 = new List<int>() { 3, 1, 0, 4, 3 };

        //}


        //[Theory]
        //[InlineData(1, 1, "2")]
        //[InlineData(1, 1, "3-2")]
        //[InlineData(2, 1, "2,3")]
        //[InlineData(2, 2, "1,2-3,4")]
        //[InlineData(2, 2, "1,2,3-6,7,10")]
        //[InlineData(2, 1, "1,8,3-6,7,10")]
        
        //[InlineData(3, 3, "1,2,3-4,6,7-2,9,11")]
        //[InlineData(4, 3, "2,2,3,4-2,2,3,4-2,2,3,4")]
        
        //[InlineData(4, 4, "2,2,3,4-2,2,3,4-2,2,3,4-2,2,3,4")]
        //public void TestCenterBiDimensionalArray(int x, int y, string s)
        //{
        //    List<List<int>> lDobleDimension = new List<List<int>>();

        //    foreach (var arrayCurrent in s.Split("-"))
        //    {
        //        List<int> lUnoUniDimensional = arrayCurrent.Replace(" ", "").Split(",").Select(s => int.Parse(s)).ToList();
        //        lDobleDimension.Add(lUnoUniDimensional);
        //    }


        //    //List<int> lUnoUniDimensional = new List<int>() { 2, 1, 3, 2, 4 };



        //    var lResult = BusyBeaver.GetDimension(lDobleDimension);

        //    Assert.Equal(y, lResult.Vertical);
        //    Assert.Equal(x, lResult.Horizontal);
        //}

        [Theory]
        [InlineData(12, "2, 1, 3, 2, 4-2, 0, 2, 0, 1-6, 2, 1, 3, 0-3, 1, 0, 4, 3")]
        [InlineData(1, "1")]
        [InlineData(3, "1,2")]
        [InlineData(10, "1,2-3,4")]
        [InlineData(6, "6,0-0,4")]
        [InlineData(5, "1,0,3-0,5,0-7,0,9")]
        [InlineData(0, "1,0,4-0,0,0-5,0,0")]
        //[InlineData(20, "1,4,5,10")]
        //[InlineData(22, "0, 1, 2, 3, 4-10, 11, 12, 13, 14-20, 21, 22, 23, 24-30, 31, 32, 33, 34")]  //para probar el orden
        public void TestBusyBeaverCoordenadaInicial(int lExpectedValue, string s)
        {
            List<List<int>> lDobleDimension = new List<List<int>>();

            foreach (var arrayCurrent in s.Split("-"))
            {
                List<int> lUnoUniDimensional = arrayCurrent.Replace(" ", "").Split(",").Select(s => int.Parse(s)).ToList();
                lDobleDimension.Add(lUnoUniDimensional);
            }

            Square square = new Square(lDobleDimension);

            //var lResult = square._CoordenadaInicial;
            //var lResult2 = square.GetNextCoordenada();
            var lResult3 = square.GetLogsFromForest();

            Assert.Equal(lExpectedValue, lResult3);
            //Assert.Equal(x, lResult.DimensionX);

        }

        //public static List<string> bigSorting(List<int> unsorted)
        //{

        //    List<int> lSource = new List<int>(){4,5,3,7,2 };
        //    List<int> lLeft = new List<int>();
        //    List<int> lRight = new List<int>();

        //    int lPivote = lSource[0];
        //    Console.WriteLine(lPivote);
        //    for (int i = 1; i < lSource.Count; i++)
        //    {
        //        if(lSource[i] < lPivote)
        //            lLeft.Add(lSource[i]);
        //    }


        //}

    }
}
