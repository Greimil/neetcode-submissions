public class Solution {
      public List<List<string>> Partition(string s)
    {
        List<List<string>> res = new List<List<string>>();


        void backtracking(int idx, List<string> path)
        {
            if (idx == s.Length)
            {
                res.Add(new List<string>(path));
                return;
            }


            for (int i = idx; i < s.Length; i++)
            {

                string sub = s.Substring(idx, i - idx + 1);
                if (!validpalindrome(sub)) continue;

                path.Add(sub);
                backtracking(i + 1, path);

                path.RemoveAt(path.Count - 1);

            }




        }

        bool validpalindrome(string s)
        {
            bool res = true;

            int left = 0;
            int right = s.Length - 1;


            while (left < right)
            {
                if (s[left] != s[right])
                {
                    res = false;
                    break;
                }
                else
                {
                    left++;
                    right--;
                }


            }

            return res;

        }


        backtracking(0, new List<string>());
        return res;

    }
}
