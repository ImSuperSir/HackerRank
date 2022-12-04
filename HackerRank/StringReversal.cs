using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class StringReversal
    {
        public static string Reverse(string pCadena)
        {
            //return string.Concat(pCadena.Select((c, i) => pCadena[pCadena.Length - (i + 1)]));

            //return new String(pCadena.Reverse().ToArray());

            char[] lArrayCaracteres = pCadena.ToCharArray();

            int lLeftPosition = 0;
            int lRightPosition = lArrayCaracteres.Length - 1;

            for (; lLeftPosition < lRightPosition;)
            {
                char lTemporal = lArrayCaracteres[lLeftPosition];
                lArrayCaracteres[lLeftPosition] = lArrayCaracteres[lRightPosition];
                lArrayCaracteres[lRightPosition] = lTemporal;
                lLeftPosition++;
                lRightPosition--;
            }

            return new string(lArrayCaracteres);

        }
    }
}
