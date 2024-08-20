using System.Drawing;

namespace Stack
{
    public class ValidateParen
    {
        public bool IsValid(string s)
        {
            char[] stack = new char[s.Length];
            int index = 0; 

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    //add items to the "stack" if it is an opening paren
                    stack[index] = c;
                    //point to the next spot in the stack
                    index++;
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (index == 0) { 

                    return false;
                    }

                    //check the top member of the stack and check to see if it has a matching closing bracket
                    char top = stack[index - 1];
                    if (!((top == '(' && c == ')') ||(top == '{' && c == '}') ||(top == '[' && c == ']')))
                    {
                        return false;
                    }
                    //move down an item "pop" the item off the stack
                    index--;
                }
            }
            return index == 0;
        }
    }
}

