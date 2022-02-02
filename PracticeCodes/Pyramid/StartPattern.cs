using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Pyramid
{
    public class StartPattern
    {
        public static void Main(string[] args)
        {
            int star = 1, n = 11, space = (n - 1) / 2;
            for(int i=0;i<n;i++)
            {
                for(int k=0;k<space;k++)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<star;j++)
                {
                    Console.Write("*");
                }
                if(space>i)
                {
                    space--;
                    star += 2;
                }
                else
                {
                    space++;
                    star -= 2;
                }
                Console.WriteLine("");
            }
        }
    }
}
