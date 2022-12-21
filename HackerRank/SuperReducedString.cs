using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class SuperReducedString
    {
        public static string Reduce(string s)
        {
            Debug.WriteLine($"La cadena de entrada {s}");

            Stack<string> lStack = new Stack<string>();


            char[] l = s.ToCharArray();

           
            

            for (int i = 0; i < s.Length; i++)
            {
                var lCurrent = s.Substring(i, 1);
                if (lStack.Count == 0)
                {
                    lStack.Push(lCurrent);
                    continue;
                }
                
                var lStackCurrent = lStack.Peek().ToString();

                if (lCurrent == lStackCurrent)
                {
                    lStack.Pop();
                }
                else
                {
                    lStack.Push(lCurrent);
                }

            }
            Console.WriteLine($"La cadena de entrada {s}");
            //return string.Empty;

            StringBuilder lRest = new StringBuilder();

            Stack<string> lStack2 = new Stack<string>();
            //string lQuitada = string.Empty;

            while (lStack.TryPeek(out _))
            {
                lStack2.Push(lStack.Pop().ToString());
            }

            while (lStack2.TryPeek(out _))
            {
                string l2 = lStack2.Pop();
                lRest.Append(l2);
            }





            return lRest.ToString() == string.Empty ? "String Empty" : lRest.ToString();
        }
    }
}
