     public class Trie
    {
        public Dictionary<char, Trie> childrens = new Dictionary<char, Trie>();
        public bool IsEndOfWord = false;

    }
 
 public class WordDictionary
    {
        Trie node;
        public WordDictionary()
        {
            node = new Trie();
        }

        public void AddWord(string word)
        {


            if (!string.IsNullOrEmpty(word))
            {
                Trie localNode = node;


                foreach (char chart in word)
                {

                    if (!localNode.childrens.TryGetValue(chart, out Trie trie))
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
            bool dfs(int i, Trie node)
            {
                // Caso base: llegamos al final del string a buscar
                if (i == word.Length)
                {
                    return node.IsEndOfWord;
                }

                char chart = word[i];

                if (chart != '.')
                {
                    // Si el nodo actual tiene el hijo con 'chart', continuar
                    if (node.childrens.ContainsKey(chart))
                    {
                        return dfs(i + 1, node.childrens[chart]);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    // '.' significa probar con todos los hijos
                    foreach (var child in node.childrens.Values)
                    {
                        if (dfs(i + 1, child))
                        {
                            return true; // si alguna rama funciona, devolvemos true
                        }
                    }
                    return false; // ninguna rama funcionó
                }
            }

            return dfs(0, node);

        }
    }