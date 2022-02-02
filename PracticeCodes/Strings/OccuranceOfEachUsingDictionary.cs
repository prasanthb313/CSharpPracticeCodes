using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Strings
{
    public class OccuranceOfEachUsingDictionary
    {
        public static void Main(string[] args)
        {
            string str = "prasanth";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            
            foreach(char ch in str)
            {
                if(dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch,1);
                }
            }
            foreach(KeyValuePair<char,int> kv in dict)
            {
                Console.WriteLine(kv.Key + "  Occured times is  " + kv.Value);
            }
        }
    }
}
