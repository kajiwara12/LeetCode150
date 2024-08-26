using System.Text;

namespace BitManipulation
{
    public class AddBinary
    {
        public string AddBinaryy(string a, string b)
        {
            int carry = 0;
            StringBuilder result = new StringBuilder();

            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = 0;
                sum += carry;

                if (i >= 0)
                {
                    if (a[i] == '1')
                    {
                        sum += 1;
                    }
                    i--;
                }

                if (j >= 0)
                {
                    if (b[j] == '1')
                    {
                        sum += 1;
                    }
                    j--;
                }

                if (sum == 0)
                {
                    result.Insert(0, '0');
                    carry = 0;
                }
                else if (sum == 1)
                {
                    result.Insert(0, '1');
                    carry = 0;
                }
                else if (sum == 2)
                {
                    result.Insert(0, '0');
                    carry = 1;
                }
                else
                {
                    result.Insert(0, '1');
                    carry = 1;
                }
            }
            return result.ToString();
        }
    }
}
