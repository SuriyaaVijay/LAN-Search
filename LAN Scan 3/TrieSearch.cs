using System;
using System.Collections.Generic;
using System.Linq;
{
    class Tries
    {
        TrieNode root;

        public void CreateRoot()
        {
            root = new TrieNode();
        }

        public void Add(char[] chars)
        {
            TrieNode tempRoot = root;
            int total = chars.Count() - 1;
            for (int i = 0; i < chars.Count(); i++)
            {
                TrieNode newTrie;
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];
                }
                else
                {
                    newTrie = new TrieNode();

                    if (total == i)
                    {
                        newTrie.endOfWord = true;
                    }

                    tempRoot.children.Add(chars[i], newTrie);
                    tempRoot = newTrie;
                }
            }
        }

        public bool FindPrefix(char[] chars)
        {
            TrieNode tempRoot = root;
            for (int i = 0; i < chars.Count(); i++)
            {
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public string FindWord(char[] chars)
        {
            TrieNode tempRoot = root;
            int total = chars.Count() - 1;
            for (int i = 0; i < chars.Count(); i++)
            {
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];

                    if (total == i)
                    {
                        if (tempRoot.endOfWord == true)
                        {
                            return chars;
                        }
                    }
                }
                else
                {
                    return chars;
                }
            }
            return chars;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool endOfWord;
    }

    public static void Main(string[] args)
    {
        Tries t = new Tries();
        if(yes != true) {
            t.CreateRoot();
        }
        byte ptr1[] = lansys.getinfo(system);
        byte ptr2[] = prev.getinfo(system);
        if (ptr1 != ptr2)
        {
            byte diff[] = ptr2 - ptr1;
            int i = 0;
            while (diff != '\0')
            {
                t.Add(diff[i].ToCharArray());
            }
            i++;
        }

    byte[] ptr = t.FindPrefix(args[1]);
        goto(formmain.cs, ptr);
    }
}

/*
Calling Code:
*/