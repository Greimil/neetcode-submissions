public class Solution {

public string Encode(IList<string> strs)
{
    List<string> encodeStr = new List<string>();

    foreach (var word in strs)
    {
        var wordLength = word.Length;

        encodeStr.Add($"{wordLength}#{word}");

    }

    string res = string.Join("", encodeStr);



    return res;

}

public List<string> Decode(string s)
{
    List<string> strings = new List<string>();



    int idx = 0;

    while (idx < s.Length)
    {
        int j = idx;

        while (s[j] != '#')
        {
            j++;
        }

        int length = int.Parse(s.Substring(idx, j - idx));
        idx = j + 1;
        j = idx + length;

        strings.Add(s.Substring(idx, length));
        idx = j;   



    }

    return strings;
}

}
