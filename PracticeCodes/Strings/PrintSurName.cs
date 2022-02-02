using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Strings
{
    public class PrintSurName
    {
        public static void Main(string[] args)
        {
            string name = "Gangadhar Vidhyadhar Shastri";
            string[] array = name.Split(' ');
            //Shastri G.V
            Console.Write(array[2] + " ");
            for (int i=0;i<array.Length-1;i++)
            {
               
                string input = array[i];
                for(int j=0;j<input.Length;j++)
                {
                    if(j==0)
                    {
                        Console.Write(input[j]);
                        break;
                    }
                }
                Console.Write(".");
            }
        }
    }
}
