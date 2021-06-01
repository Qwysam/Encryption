//using Elskom.Generic.Libs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    //class for Caesar cypher
    public class Caesar
    {
        //dictionary to access shifted char while cyphering
        private Dictionary<char, char> cypher_table;

        //dictionary to access shifted char while decyphering
        private Dictionary<char, char> decypher_table;

        //fills cypher_table with chars using specified shift
        public void CreateDictionaryCypher(int shift)
        {
            cypher_table = new Dictionary<char, char>();
            //cycle for char shifting for all UTF-8 symbols
            for (char c = char.MinValue; c < char.MaxValue; c++)
            {
                //char to int
                int tmp = c;
                //choose shift direction
                if (c <= char.MaxValue - shift)
                    cypher_table.Add(c, (char)(tmp + shift));
                else
                {
                    //adjustments if shift exeeds char value limit
                    int carry = char.MaxValue - (c + shift);
                    char after_shift = (char)carry;
                    cypher_table.Add(c, after_shift);
                }

            }
        }

        //fills decypher_table with chars using specified shift
        public void CreateDictionaryDecypher(int shift)
        {
            decypher_table = new Dictionary<char, char>();
            //cycle for char shifting for all UTF-8 symbols
            for (char c = char.MinValue; c < char.MaxValue; c++)
            {
                //char to int
                int tmp = c;
                //choose shift direction
                if (c >= (char)0 + shift)
                    decypher_table.Add(c, (char)(tmp - shift));
                else
                {
                    //adjustments if shift is lower than char minimal value
                    int carry = c + shift - char.MaxValue;
                    char after_shift = (char)carry;
                    decypher_table.Add(c, after_shift);
                }

            }
        }

        //return string after cyphering
        public string Cypher(string input)
        {
            List<char> list = new List<char>();
            foreach (char c in input)
            {
                list.Add(cypher_table[c]);
            }
            return new string(list.ToArray());
        }

        //return string after decyphering
        public string Decypher(string input)
        {
            List<char> list = new List<char>();
            foreach (char c in input)
            {
                list.Add(decypher_table[c]);
            }
            return new string(list.ToArray());
        }

        //private void AsyncCypher(out string input)
        //{
        //    string res = "";
        //    foreach (char c in input)
        //    {
        //        res += decypher_table[c];
        //    }
        //}

        public string ParallelCypher(string input)
        {

            string[] parts = new string[4];
            parts[0] = input.Substring(0, input.Length / 4);
            parts[1] = input.Substring(parts[0].Length, input.Length / 2);
            parts[2] = input.Substring(parts[0].Length + parts[1].Length, input.Length / 4 * 3);
            parts[3] = input.Substring(parts[0].Length + parts[1].Length + parts[2].Length);
            Task<string> task1 = new Task<string>(() =>
               {
                   parts[0] = Cypher(parts[0]);
                   return parts[0];
               });
            Task<string> task2 = new Task<string>(() =>
            {
                parts[1] = Cypher(parts[1]);
                return parts[1];
            });
            Task<string> task3 = new Task<string>(() =>
            {
                parts[2] = Cypher(parts[2]);
                return parts[2];
            });
            Task<string> task4 = new Task<string>(() =>
            {
                parts[3] = Cypher(parts[3]);
                return parts[3];
            });
            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            Task.WaitAll(task1, task2, task3, task4);
            return parts[0] + parts[1] + parts[2] + parts[3];
        }
    }

    //class for DES Encryption
    public class Des
    {
        //bool variable to check if the key exists
        public bool HasKey { get { return key != null; } }
        //grants access to the key to show it to the uset
        public byte[] Key { get { return key; } set { key = value; } }
        //stores the ke
        private byte[] key;
        //generates the key
        public void GetKey()
        {
            DES tmp = DES.Create();
            this.key = tmp.Key;
        }
        //returns encrypted string
        public string Encrypt(string text)
        {
            //will return null string the key doesnt exist
            if (key != null)
            {
                //initialization vector for more secure encryption of the beginning of the message
                byte[] IV = { 15, 27, 39, 41, 56, 66, 79, 90 };
                //array to store char bytecode
                byte[] array;

                try
                {
                    //Predefined C# class  
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    //string to byte array
                    array = Encoding.UTF8.GetBytes(text);
                    //Use of predefined classes
                    MemoryStream Mstream = new MemoryStream();
                    CryptoStream CryptoStream = new CryptoStream(Mstream, DES.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                    CryptoStream.Write(array, 0, array.Length);
                    //clean the buffer
                    CryptoStream.FlushFinalBlock();
                    //result
                    return Convert.ToBase64String(Mstream.ToArray());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                return null;
        }

        public string Decrypt(string text)
        {
            //will return null string the key doesnt exist
            if (key != null)
            {
                //initialization vector for more secure encryption of the beginning of the message
                byte[] IV = { 15, 27, 39, 41, 56, 66, 79, 90 };
                //array to store char bytecode
                byte[] array = Encoding.UTF8.GetBytes(text);

                try
                {
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    array = Convert.FromBase64String(text);
                    //Use of predefined classes
                    MemoryStream Mstream = new MemoryStream();
                    CryptoStream CryptoStream = new CryptoStream(Mstream, DES.CreateDecryptor(key, IV), CryptoStreamMode.Write);
                    CryptoStream.Write(array, 0, array.Length);
                    CryptoStream.FlushFinalBlock();
                    //Decrypted string in UTF-8
                    Encoding encoding = Encoding.UTF8;
                    return encoding.GetString(Mstream.ToArray());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                return null;
        }
    }

    //class Blowfish
    //{
    //    public BlowFish entity;
    //    public byte[] Key;
    //    public Blowfish(byte[] key)
    //    {
    //        Key = key;
    //        entity = new BlowFish(key);
    //    }

    //    public string Encrypt(string data)
    //    {
    //        byte[] tmp = Encoding.UTF8.GetBytes(data);
    //        tmp = entity.EncryptCBC(tmp);
    //        return Encoding.UTF8.GetString(tmp);
    //    }

    //    public string Decrypt(string data)
    //    {
    //        byte[] tmp = Encoding.UTF8.GetBytes(data);
    //        tmp = entity.DecryptCBC(tmp);
    //        return Encoding.UTF8.GetString(tmp);
    //    }
    //}
}