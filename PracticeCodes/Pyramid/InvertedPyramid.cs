using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Pyramid
{
    public class InvertedPyramid
    {
        public static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter the number of rows");
            int l=int.Parse(Console.ReadLine());
            for(i=l;i>=0;i--)
            {
                for(j=i;j>=0;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

