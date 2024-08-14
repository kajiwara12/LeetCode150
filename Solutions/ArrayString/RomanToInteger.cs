using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<string, int> Roman = new Dictionary<string, int>();
            Roman.Add("I", 1);
            Roman.Add("V", 5);
            Roman.Add("X", 10);
            Roman.Add("L", 50);
            Roman.Add("C", 100);
            Roman.Add("D", 500);
            Roman.Add("M", 1000);
            Roman.Add("IV", 4);
            Roman.Add("IX", 9);
            Roman.Add("XL", 40);
            Roman.Add("XC", 90);
            Roman.Add("CD", 400);
            Roman.Add("CM", 900);


            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && Roman.ContainsKey($"{s[i]}{s[i + 1]}"))
                {
                    result += Roman[$"{s[i]}{s[i + 1]}"];
                    i++;
                }
                else if (Roman.ContainsKey(s[i].ToString()))
                {
                    result += Roman[s[i].ToString()];
                }
            }

            return result;
        }
    }
}
