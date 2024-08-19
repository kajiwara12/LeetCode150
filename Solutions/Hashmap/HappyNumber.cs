using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashmap
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            HashSet<int> seen = new();
            while (true)
            {
                int sum = 0;
                while (n != 0)
                {
                    int last = n % 10;
                    sum += last * last;
                    n /= 10;
                }
                n = sum;
                if (n == 1)
                {
                    return true;
                }
                if (seen.Contains(n))
                {
                    return false;
                }
                seen.Add(n);
            }
        
        }
    }
}

