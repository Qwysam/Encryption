
namespace Encryption
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_load_file = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.radioButton_des = new System.Windows.Forms.RadioButton();
            this.radioButton_blowfish = new System.Windows.Forms.RadioButton();
            this.radioButton_caesar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_load_file
            // 
            this.button_load_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_load_file.Location = new System.Drawing.Point(36, 81);
            this.button_load_file.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_load_file.Name = "button_load_file";
            this.button_load_file.Size = new System.Drawing.Size(268, 50);
            this.button_load_file.TabIndex = 0;
            this.button_load_file.Text = "Выбрать файл";
            this.button_load_file.UseVisualStyleBackColor = true;
            this.button_load_file.Click += new System.EventHandler(this.button_load_file_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_encrypt.Location = new System.Drawing.Point(36, 181);
            this.button_encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(268, 50);
            this.button_encrypt.TabIndex = 1;
            this.button_encrypt.Text = "Шифровать";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_decrypt.Location = new System.Drawing.Point(36, 281);
            this.button_decrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(268, 50);
            this.button_decrypt.TabIndex = 2;
            this.button_decrypt.Text = "Дешифровать";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // radioButton_des
            // 
            this.radioButton_des.AutoSize = true;
            this.radioButton_des.Location = new System.Drawing.Point(48, 46);
            this.radioButton_des.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_des.Name = "radioButton_des";
            this.radioButton_des.Size = new System.Drawing.Size(105, 37);
            this.radioButton_des.TabIndex = 3;
            this.radioButton_des.TabStop = true;
            this.radioButton_des.Text = "DES";
            this.radioButton_des.UseVisualStyleBackColor = true;
            // 
            // radioButton_blowfish
            // 
            this.radioButton_blowfish.AutoSize = true;
            this.radioButton_blowfish.Location = new System.Drawing.Point(48, 146);
            this.radioButton_blowfish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_blowfish.Name = "radioButton_blowfish";
            this.radioButton_blowfish.Size = new System.Drawing.Size(155, 37);
            this.radioButton_blowfish.TabIndex = 4;
            this.radioButton_blowfish.TabStop = true;
            this.radioButton_blowfish.Text = "Blowfish";
            this.radioButton_blowfish.UseVisualStyleBackColor = true;
            // 
            // radioButton_caesar
            // 
            this.radioButton_caesar.AutoSize = true;
            this.radioButton_caesar.Location = new System.Drawing.Point(48, 246);
            this.radioButton_caesar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_caesar.Name = "radioButton_caesar";
            this.radioButton_caesar.Size = new System.Drawing.Size(236, 37);
            this.radioButton_caesar.TabIndex = 5;
            this.radioButton_caesar.TabStop = true;
            this.radioButton_caesar.Text = "Шифр Цезаря";
            this.radioButton_caesar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_des);
            this.groupBox1.Controls.Add(this.radioButton_blowfish);
            this.groupBox1.Controls.Add(this.radioButton_caesar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(390, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритмы";
            // 
            // textBox_key
            // 
            this.textBox_key.Enabled = false;
            this.textBox_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_key.Location = new System.Drawing.Point(390, 417);
            this.textBox_key.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.ReadOnly = true;
            this.textBox_key.Size = new System.Drawing.Size(296, 40);
            this.textBox_key.TabIndex = 7;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_key.Location = new System.Drawing.Point(384, 379);
            this.label_key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(88, 33);
            this.label_key.TabIndex = 8;
            this.label_key.Text = "Ключ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 500);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.button_load_file);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Шифрування даних";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_load_file;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.RadioButton radioButton_des;
        private System.Windows.Forms.RadioButton radioButton_blowfish;
        private System.Windows.Forms.RadioButton radioButton_caesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Label label_key;
    }
}

