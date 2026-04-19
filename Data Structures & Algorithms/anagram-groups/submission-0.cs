public class Solution {

 public List<List<string>> GroupAnagrams(string[] strs)
{

    var dict = new Dictionary<string, List<string>>();

    Array.Sort(strs, (a, b) => a.Length - b.Length);

    for (int i = 0; i < strs.Length; i++)
    {

        var Sortedword = strs[i];
        char[] chars = Sortedword.ToCharArray();
        Array.Sort(chars);
        Sortedword = new string(chars);

        var word = strs[i];

        if (dict.ContainsKey(Sortedword))
        {
            dict[Sortedword].Add(word);
        }
        else
        {


            dict[Sortedword] = new List<string> { word };

        }


    }


    return dict.Values.ToList();

   

}

}
