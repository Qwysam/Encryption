using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Encryption
{
    class Caesar
    {
        private Dictionary<char, char> cypher_table;

        private Dictionary<char, char> decypher_table;

        public void CreateDictionaryCypher(int shift)
        {
            cypher_table = new Dictionary<char, char>();
            for(char c = char.MinValue; c < char.MaxValue; c++)
            {
                int tmp = c;
                if (c <= char.MaxValue - shift)
                    cypher_table.Add(c, (char)(tmp + shift));
                else
                {
                    int carry = char.MaxValue - (c + shift);
                    char after_shift = (char)carry;
                    cypher_table.Add(c, after_shift);
                }

            }
        }

        public void CreateDictionaryDecypher(int shift)
        {
            decypher_table = new Dictionary<char, char>();
            for (char c = char.MinValue; c < char.MaxValue; c++)
            {
                int tmp = c;
                if (c >= (char)0 + shift)
                    decypher_table.Add(c, (char)(tmp - shift));
                else
                {
                    int carry = c + shift - char.MaxValue;
                    char after_shift = (char)carry;
                    decypher_table.Add(c, after_shift);
                }

            }
        }

        public string Cypher(string input)
        {
            string res = "";
            foreach(char c in input)
            {
                res += cypher_table[c];
            }
            return res;
        }

        public string Decypher(string input)
        {
            string res = "";
            foreach (char c in input)
            {
                res += decypher_table[c];
            }
            return res;
        }
    }
}
