public class Solution {
    public bool IsValid(string s)
{

    Stack<char> stack = new Stack<char>();

    foreach (char str in s)
    {
        if (str == '(' || str == '{' || str == '[')
        {
            stack.Push(str);
        }
        else
        {
            if (stack.Count == 0) return false;

            if ((stack.Peek() == '(' && str == ')') ||
            (stack.Peek() == '[' && str == ']')
            || (stack.Peek() == '{' && str == '}'))
            {
                stack.Pop();
            }
            else
            {
                return false;
            }


        }



    }



    return stack.Count == 0;
}
}
