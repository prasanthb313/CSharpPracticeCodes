using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Pyramid
{
    public class FirstTest
    {
        public static void Main(string[] args)
        {
            int i, j;
            for(i=0;i<5;i++)
            {
                for(j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
