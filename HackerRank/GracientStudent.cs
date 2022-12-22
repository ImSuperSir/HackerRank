using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public  class GradeRedundant
    {

        /// <summary>
        /// calificaciones >= 38 and proximo multiplo de
        /// 5 esta a menos de dos, tonces se redondea hacia arriba
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static List<int> Test(List<int> grades)
        {
            List<int> Upgraded = new List<int>();
            foreach (int l in grades)
            {
                Console.Write($"Antes: {l}");
                Upgraded.Add(Roundit(l));
                Console.Write($"Despues{Roundit(l)}\n");
            }

            foreach (int l in grades)
            {
                Console.Write($"Despues{l}\n");
            }

            return Upgraded;
        }

        public static int Roundit(int pGrade)
        {
            if (pGrade >= 38 && ((pGrade % 5) >= 3))
            {
                pGrade += (5 - (pGrade % 5));
            }
            return pGrade;
        }
    }
}
