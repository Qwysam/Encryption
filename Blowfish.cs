using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Elskom.Generic.Libs;

namespace Encryption
{
    class Blowfish
    {
        public BlowFish entity;

        public Blowfish(byte[] key)
        {
            entity = new BlowFish(key);
        }

        public string Encrypt(string data)
        {
            byte[] tmp = Encoding.UTF8.GetBytes(data);
            tmp = entity.EncryptCBC(tmp);
            return Encoding.UTF8.GetString(tmp);
        }

        public string Decrypt(string data)
        {
            byte[] tmp = Encoding.UTF8.GetBytes(data);
            tmp = entity.DecryptCBC(tmp);
            return Encoding.UTF8.GetString(tmp);
        }
    }
}
