using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace TwoPointer
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        { 
            string Q = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty).ToLower();
            int leftPointer = 0;
            int rightPointer = Q.Length-1;
            while (leftPointer < rightPointer)
            {
                if (Q[leftPointer] != Q[rightPointer])
                {
                    return false;
                }
                leftPointer++;
                rightPointer--;

            }
            return true;
        }
    }
}