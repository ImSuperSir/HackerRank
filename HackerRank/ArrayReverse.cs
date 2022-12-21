using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Array
    {
        /// <summary>
        /// Reverse an array
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static List<int> reverseArray(List<int> a)
        {
            int ltemp = 0;
            for (int i = 0; i < ((int)(a.Count / 2)); i++)
            {
                ltemp = a[i];
                a[i] = a[a.Count - 1 - i];  //take care when i=0
                a[a.Count - 1 - i] = ltemp;  //take care when i = 0

            }
            return a.ToList();
        }

    }
}
