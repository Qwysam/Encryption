//using Elskom.Generic.Libs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    //class for Caesar cypher
    class Caesar
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
            string res = "";
            foreach (char c in input)
            {
                res += cypher_table[c];
            }
            return res;
        }

        //return string after decyphering
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

    //class for DES Encryption
    class Des
    {
        //bool variable to check if the key exists
        public bool HasKey { get { return key != null; } }
        //grants access to the key to show it to the uset
        public byte[] Key { get { return key; } }
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
                byte[] array = new byte[text.Length];

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