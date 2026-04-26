public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var openB = new HashSet<char>() { '[', '(', '{' };

        foreach (char c in s) {
            if (openB.Contains(c)) {
                stack.Push(c);
            } else {
               
                if (stack.Count == 0) return false;

                char top = stack.Peek();

                
                if (c == ']' && top != '[') return false;
                if (c == ')' && top != '(') return false;
                if (c == '}' && top != '{') return false;

                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}