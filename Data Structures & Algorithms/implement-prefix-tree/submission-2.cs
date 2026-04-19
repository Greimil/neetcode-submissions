    public class Trie
    {
        public Dictionary<char, Trie> childrens = new Dictionary<char, Trie>();
        public bool IsEndOfWord = false;

    }
    public class PrefixTree
    {
        public Trie node;
        public PrefixTree()
        {
            node = new Trie();
        }

        public void Insert(string word)
        {
            Trie localNode = node;

            if (!string.IsNullOrEmpty(word))
            {

                foreach (char chart in word)
                {
                    
                    if (!localNode.childrens.TryGetValue(chart, out Trie trie) )
                    {
                        trie = new Trie();
                        localNode.childrens[chart] = trie;
                    }

                    localNode = trie;
                }

                localNode.IsEndOfWord = true;

            }


        }

        public bool Search(string word)
        {
            Trie localNode = node;

            foreach (char chart in word)
            {
                if (!localNode.childrens.ContainsKey(chart))
                {
                    return false;

                }


                localNode = localNode.childrens[chart];

            }

            return localNode.IsEndOfWord;

        }

        public bool StartsWith(string prefix)
        {
            Trie localNode = node;

            foreach (char chart in prefix)
            {
                if (!localNode.childrens.ContainsKey(chart)) return false;

                localNode = localNode.childrens[chart];
            }

            return true;

        }
    }

