using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class CamelCase
    {
        public static int Test(string s)
        {
            //Console.WriteLine(s);

            List<string> lWords = new List<string>();
            StringBuilder lCurrentString = new StringBuilder();
            foreach (char lChar in s.ToCharArray())
            {
                if (char.IsUpper(lChar))
                {
                    if (lCurrentString.ToString().Length > 0)
                    {
                        lWords.Add(lCurrentString.ToString());
                        lCurrentString = new StringBuilder();
                    }
                }

                lCurrentString.Append(lChar);

            }

            if (lCurrentString.ToString().Length > 0)
            {
                lWords.Add(lCurrentString.ToString());
                lCurrentString = new StringBuilder();
            }

            return lWords.Count();
        }

    }
}
