using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class StringPassword
    {


        /// <summary>
        /// Calculate the number of characters to be a strong password
        /// at least 6 length
        /// 1 number, 1 lowercase, 1 UpperCase, 1 special character
        /// </summary>
        /// <param name="n"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public static int Test(int n, string pPassword)
        {
            char[] lNumeros = "0123456789".ToCharArray();
            char[] lLowerCase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] lUpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] lSpecial = "!@#$%^&*()-+".ToCharArray();

            //HashSet<char> lPasswordSet = new HashSet<char>();

            int lMustAdd = 0;
            if (pPassword.Intersect(lNumeros).Count() == 0)
                lMustAdd++;
            if (pPassword.Intersect(lLowerCase).Count() == 0)
                lMustAdd++;
            if (pPassword.Intersect(lUpperCase).Count() == 0)
                lMustAdd++;
            if (pPassword.Intersect(lSpecial).Count() == 0)
                lMustAdd++;

            Console.WriteLine($"Password:{pPassword} NumFaltante{lMustAdd}");

            // var lResult = pPasswork.Distinct(); (()) .Intersect(pPasswork.ToCharArray());

            return  Math.Max((6 - n), lMustAdd);
           
        }

      
    }
}
