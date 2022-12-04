using System.Diagnostics.CodeAnalysis;

namespace HackerRank
{
    public class CountBinarySubstrings
    {

        /// <summary>
        /// Count the consecutive substring of zeros and 1
        /// that exist in one cadena
        /// </summary>
        /// <param name="pBinaryString"></param>
        /// <returns></returns>
        public int Count(string pBinaryString)
        {
            List<int> lConsecutivosCounter = new List<int>();

            int lCurrentCounter=1;
            char lCurrentChar = pBinaryString[0];
            lConsecutivosCounter.Add(1);


            for (int i = 1; i < pBinaryString.Length; i++)
            {
                if (pBinaryString[i - 1] == pBinaryString[i])
                    lConsecutivosCounter[lConsecutivosCounter.Count-1] += 1;
                else 
                    lConsecutivosCounter.Add(1);
            }

            int lNumCombinaciones = 0;
            for (int i = 1; i < lConsecutivosCounter.Count; i++)
            { 
                lNumCombinaciones += Math.Min(lConsecutivosCounter[i-1], lConsecutivosCounter[i]);
            }

            return lNumCombinaciones;
        }

    }
}