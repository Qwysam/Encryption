using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        Des DES = new Des();
        public bool file_selected;
        public string text;
        public Form1()
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
                textBox_key.Text = Encoding.Default.GetString(DES.Key);
                string res = DES.Encrypt(text);
                File.WriteAllText("des_enc.txt", res);
            }

            if (radioButton_blowfish.Checked)
            {

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
                    textBox_key.Text = Encoding.Default.GetString(DES.Key);
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
