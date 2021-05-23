using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BlowFish_namespace;

namespace Encryption
{
    public partial class MainForm : Form
    {
        public byte[] blowfish_key;
        Des DES = new Des();
        BlowFish BlowFish;
        public bool file_selected;
        public string text;
        public string ASCII_Text;
        public MainForm()
        {
            InitializeComponent();
            label_key.Hide();
            textBox_key.Hide();
            radioButton_des.Checked = true;
            button_decrypt.Enabled = false;
            button_encrypt.Enabled = false;
        }

        private void button_load_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.Filter = "TXT Files|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileStream = ofd.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream, encoding: Encoding.UTF8))
                {
                    text = reader.ReadToEnd();
                }
                ASCII_Text = File.ReadAllText(ofd.FileName, Encoding.ASCII);
                button_decrypt.Enabled = true;
                button_encrypt.Enabled = true;
            }
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            if (radioButton_des.Checked)
            {
                DES.GetKey();
                label_key.Show();
                label_key.Text = "Ключ DES";
                textBox_key.Show();
                textBox_key.Text = Convert.ToBase64String(DES.Key);
                string res = DES.Encrypt(text);
                File.WriteAllText("des_enc.txt", res);
            }

            if (radioButton_blowfish.Checked)
            {
                label_key.Show();
                label_key.Text = "Ключ BlowFish";
                textBox_key.Show();
                Des tmp = new Des();
                tmp.GetKey();
                blowfish_key = tmp.Key;
                BlowFish = new BlowFish(blowfish_key);
                textBox_key.Text = Convert.ToBase64String(blowfish_key);
                BlowFish.SetRandomIV();
                //byte[] input = Encoding.UTF8.GetBytes(text);
                //byte[] enc = BlowFish.EncryptCBC(input);
                string save_info = BlowFish.EncryptCBC(text);
                File.WriteAllText("blowfish_enc.txt", save_info,Encoding.UTF8);
            }

            if (radioButton_caesar.Checked)
            {
                label_key.Hide();
                textBox_key.Hide();
                Caesar Caesar = new Caesar();
                Caesar.CreateDictionaryCypher(13);
                string res = Caesar.Cypher(text);
                File.WriteAllText("caesar_enc.txt", res);
            }

            button_decrypt.Enabled = false;
            button_encrypt.Enabled = false;
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            if (radioButton_des.Checked)
            {
                if (DES.HasKey)
                {
                    label_key.Show();
                    label_key.Text = "Ключ DES";
                    textBox_key.Show();
                    textBox_key.Text = Convert.ToBase64String(DES.Key);
                    string res = DES.Decrypt(text);
                    File.WriteAllText("des_dec.txt", res,Encoding.UTF8);
                }
                else
                {
                    MessageBox.Show("Необходим ключ для дешифрования!");
                }
            }

            if (radioButton_blowfish.Checked)
            {
                if(BlowFish!= null)
                {
                    label_key.Show();
                    label_key.Text = "Ключ BlowFish";
                    textBox_key.Show();      
                    textBox_key.Text = Convert.ToBase64String(blowfish_key);
                    //byte[] input = Encoding.ASCII.GetBytes(ASCII_Text);
                    //byte[] res = BlowFish.DecryptCBC(input);
                    string save_info = BlowFish.DecryptCBC(text);
                    File.WriteAllText("blowfish_dec.txt", save_info,Encoding.UTF8);
                }
                else
                {
                    MessageBox.Show("Необходим ключ для дешифрования!");
                }
            }

            if (radioButton_caesar.Checked)
            {
                label_key.Hide();
                textBox_key.Hide();
                Caesar Caesar = new Caesar();
                Caesar.CreateDictionaryDecypher(13);
                string res = Caesar.Decypher(text);
                File.WriteAllText("caesar_dec.txt", res, Encoding.UTF8);
            }

            button_decrypt.Enabled = false;
            button_encrypt.Enabled = false;
        }
    }
}
