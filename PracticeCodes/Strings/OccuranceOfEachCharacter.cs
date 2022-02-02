using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Strings
{
    public class OccuranceOfEachCharacter
    {
        public static void Main(string[] args)
        {
            string str = "abcabc";

            for(int i=0;i<str.Length;i++)
            {
                int count = 0;
                char ch = str[i];
                for(int j=0;j<str.Length;j++)
                {
                    char ch2 = str[j];
                    if (j < i && ch == ch2)
                        break;
                    else if (ch == ch2)
                        count++;
                    else if(j==str.Length-1)
                        Console.WriteLine("Character  " + ch + " Occured  " + count + "times");
                }
                
            }
        }
    }
}
