public class Solution {
        public int EvalRPN(string[] tokens)
    {
        Stack<int> result = new Stack<int>();
      
        foreach (var token in tokens)
        {
            if (!(token == "+") && !(token == "-") && !(token == "*") && !(token == "/"))
            {
                result.Push(int.Parse(token));
            }
            else
            {

                int num2 = result.Pop();
                int num1 = result.Pop();


                switch (token)
                {
                    case "+":
                        result.Push(num1 + num2);
                        break;
                    case "-":
                        result.Push(num1 - num2);
                        break;
                    case "*":
                        result.Push(num1 * num2);
                        break;
                    case "/":
                        result.Push(num1 / num2);
                        break;
                }



            }



        }


        return result.Peek();

    }
}
