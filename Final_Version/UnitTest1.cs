using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption;
using BlowFish_namespace;
using System.IO;
using System.Linq;

namespace TestProjectCourseWork
{
    [TestClass]
    public class UnitTestRussianFiction
    {
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptFiction()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев. Война и мир. Книга 1.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_des_enc.txt",des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptFiction()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_des_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_des_dec.txt", des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_des_dec.txt")
                .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев. Война и мир. Книга 1.txt")), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptFiction()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев. Война и мир. Книга 1.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_blowfish_enc.txt", blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptFiction()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_blowfish_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_blowfish_dec.txt", blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_blowfish_dec.txt")
               .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев. Война и мир. Книга 1.txt")), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptFiction()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев. Война и мир. Книга 1.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_caesar_enc.txt", caesar.Cypher(text));

        }
        [TestMethod]
        public void TestMethodCaesarDecryptFiction()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_caesar_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_caesar_dec.txt", caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев.Война и мир.Книга 1_caesar_dec.txt")
              .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Толстой Лев. Война и мир. Книга 1.txt")), true);
        }
    }
    [TestClass]
    public class UnitTestUkrainianFiction
    {
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptFiction()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_des_enc.txt", des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptFiction()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_des_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_des_dec.txt", des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_des_dec.txt")
               .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка.txt")), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptFiction()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_blowfish_enc.txt", blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptFiction()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_blowfish_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_blowfish_dec.txt", blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_blowfish_dec.txt")
              .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка.txt")), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptFiction()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_caesar_enc.txt", caesar.Cypher(text));
        }
        [TestMethod]
        public void TestMethodCaesarDecryptFiction()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_caesar_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_caesar_dec.txt", caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка_caesar_dec.txt")
              .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Леся Українка. Збiрка.txt")), true);
        }
    }
    [TestClass]
    public class UnitTestEnglishFiction
    {
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptFiction()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_des_enc.txt", des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptFiction()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_des_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_des_dec.txt", des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_des_dec.txt")
               .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations.txt")), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptFiction()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_blowfish_enc.txt", blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptFiction()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_blowfish_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_blowfish_dec.txt", blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_blowfish_dec.txt")
              .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations.txt")), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptFiction()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_caesar_enc.txt", caesar.Cypher(text));
        }
        [TestMethod]
        public void TestMethodCaesarDecryptFiction()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_caesar_enc.txt");
            File.WriteAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_caesar_dec.txt", caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations_caesar_dec.txt")
              .SequenceEqual(File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Texts\\Great Expectations.txt")), true);
        }
    }

    [TestClass]
    public class UnitTestRussianScience
    {
        string basic_path = "C:\\Users\\zhdan\\Desktop\\Texts\\Гумилев.Л.Н.Этногенез и биосфера Земли.txt";
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptScience()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt","_des_enc.txt"), des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptScience()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path.Replace(".txt","_des_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_des_dec.txt"), des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_des_dec.txt"))
                .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptScience()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"), blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptScience()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"), blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"))
               .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptScience()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_enc.txt"), caesar.Cypher(text));

        }
        [TestMethod]
        public void TestMethodCaesarDecryptScience()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_caesar_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_dec.txt"), caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_caesar_dec.txt"))
              .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
    }
    [TestClass]
    public class UnitTestUkrainianScience
    {
        string basic_path = "C:\\Users\\zhdan\\Desktop\\Texts\\Історія української літературної мови.txt";
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptScience()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_des_enc.txt"), des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptScience()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path.Replace(".txt", "_des_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_des_dec.txt"), des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_des_dec.txt"))
                .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptScience()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"), blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptScience()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"), blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"))
               .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptScience()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_enc.txt"), caesar.Cypher(text));

        }
        [TestMethod]
        public void TestMethodCaesarDecryptScience()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_caesar_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_dec.txt"), caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_caesar_dec.txt"))
              .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
    }
    [TestClass]
    public class UnitTestEnglishScience
    {
        string basic_path = "C:\\Users\\zhdan\\Desktop\\Texts\\Applied Cryptography.txt";
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptScience()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_des_enc.txt"), des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptScience()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path.Replace(".txt", "_des_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_des_dec.txt"), des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_des_dec.txt"))
                .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptScience()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"), blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptScience()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"), blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"))
               .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptScience()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_enc.txt"), caesar.Cypher(text));

        }
        [TestMethod]
        public void TestMethodCaesarDecryptScience()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_caesar_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_dec.txt"), caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_caesar_dec.txt"))
              .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
    }

    [TestClass]
    public class UnitTestRussianPublicistic
    {
        string basic_path = "C:\\Users\\zhdan\\Desktop\\Texts\\Философия Энди Уорхола.txt";
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptPublicistic()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_des_enc.txt"), des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptPublicistic()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path.Replace(".txt", "_des_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_des_dec.txt"), des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_des_dec.txt"))
                .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptPublicistic()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"), blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptPublicistic()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"), blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"))
               .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptPublicistic()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_enc.txt"), caesar.Cypher(text));

        }
        [TestMethod]
        public void TestMethodCaesarDecryptPublicistic()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_caesar_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_dec.txt"), caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_caesar_dec.txt"))
              .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
    }
    [TestClass]
    public class UnitTestUkrainianPublicistic
    {
        string basic_path = "C:\\Users\\zhdan\\Desktop\\Texts\\Міхновський М.І.Суспільно_політичні_твори.txt";
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptPublicistic()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_des_enc.txt"), des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptPublicistic()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path.Replace(".txt", "_des_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_des_dec.txt"), des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_des_dec.txt"))
                .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptPublicistic()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"), blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptPublicistic()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"), blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"))
               .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptPublicistic()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_enc.txt"), caesar.Cypher(text));

        }
        [TestMethod]
        public void TestMethodCaesarDecryptPublicistic()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_caesar_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_dec.txt"), caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_caesar_dec.txt"))
              .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
    }
    [TestClass]
    public class UnitTestEnglishPublicistic
    {
        string basic_path = "C:\\Users\\zhdan\\Desktop\\Texts\\Kipling. From Sea to Sea.txt";
        private byte[] test_key = { 246, 238, 164, 75, 161, 141, 25, 128 };
        [TestMethod]
        public void TestMethodDESEncryptPublicistic()
        {
            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_des_enc.txt"), des.Encrypt(text));
        }
        [TestMethod]
        public void TestMethodDESDecryptPublicistic()
        {

            Des des = new Des();
            des.Key = test_key;
            string text = File.ReadAllText(basic_path.Replace(".txt", "_des_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_des_dec.txt"), des.Decrypt(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_des_dec.txt"))
                .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodBlowFishEncryptPublicistic()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"), blowFish.EncryptCBC(text));
        }
        [TestMethod]
        public void TestMethodBlowFishDecryptPublicistic()
        {
            BlowFish blowFish = new BlowFish(test_key);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_blowfish_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"), blowFish.DecryptCBC(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_blowfish_dec.txt"))
               .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
        [TestMethod]
        public void TestMethodCaesarEncryptPublicistic()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryCypher(13);
            string text = File.ReadAllText(basic_path);
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_enc.txt"), caesar.Cypher(text));

        }
        [TestMethod]
        public void TestMethodCaesarDecryptPublicistic()
        {
            Caesar caesar = new Caesar();
            caesar.CreateDictionaryDecypher(13);
            string text = File.ReadAllText(basic_path.Replace(".txt", "_caesar_enc.txt"));
            File.WriteAllText(basic_path.Replace(".txt", "_caesar_dec.txt"), caesar.Decypher(text));
            Assert.AreEqual(File.ReadAllText(basic_path.Replace(".txt", "_caesar_dec.txt"))
              .SequenceEqual(File.ReadAllText(basic_path)), true);
        }
    }
}
