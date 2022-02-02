using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Array
{
    public class ElementsIntoMatrix
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adding elements into array");

            // int[,] arr = new int[3, 3]; //declaration of 2D array
            //  int[,,] threed = new int[3, 3, 3]; //declaration of 3D array
            Console.WriteLine("Enter row size of the array");
            int rowsize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column size of the array");
            int colsize = int.Parse(Console.ReadLine());

            int[,] arr = new int[rowsize, colsize]; //declaration of 2D array

            for(int i=0;i<rowsize;i++)
            {
                for(int j=0;j<colsize;j++)
                {
                    int element = int.Parse(Console.ReadLine());
                    arr[i,j] = element;
                }
            }
            for (int i = 0; i < rowsize; i++)
            {
                for (int j = 0; j < colsize; j++)
                {
                    Console.Write(arr[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
