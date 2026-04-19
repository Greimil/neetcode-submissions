public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Trie trie =  new Trie();

        foreach(string str in strs) {
            trie.insert(str);
        }

        return trie.searchLongestPrefix();
    }

    public class TrieNode {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool isLeaf = false;
    }

    public class Trie {
        public readonly TrieNode root = new TrieNode();

        public void insert(string str) {
            TrieNode curr = root;

            foreach (char c in str) {
                if (!curr.children.ContainsKey(c)) {
                    curr.children.Add(c, new TrieNode());
                }

                curr = curr.children[c];
            }

            curr.isLeaf = true;
        }
    
        public string searchLongestPrefix(){
            string longestPrefix = "";
             TrieNode curr = root;

             while(curr.children.Count == 1 && !curr.isLeaf) {
                char key = curr.children.Keys.First();
                longestPrefix += key;
                curr = curr.children[key];
             }

            return longestPrefix;
            
        }
    
    
    }
}