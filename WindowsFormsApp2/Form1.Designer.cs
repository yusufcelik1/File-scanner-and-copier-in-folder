
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaynak = new System.Windows.Forms.Button();
            this.txtKaynak = new System.Windows.Forms.TextBox();
            this.txtHedef = new System.Windows.Forms.TextBox();
            this.btnHedef = new System.Windows.Forms.Button();
            this.Kopyala = new System.Windows.Forms.Button();
            this.TumunuKopyala = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 108);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaynak
            // 
            this.btnKaynak.Location = new System.Drawing.Point(658, 30);
            this.btnKaynak.Name = "btnKaynak";
            this.btnKaynak.Size = new System.Drawing.Size(75, 20);
            this.btnKaynak.TabIndex = 2;
            this.btnKaynak.Text = "Kaynak Seç";
            this.btnKaynak.UseVisualStyleBackColor = true;
            this.btnKaynak.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKaynak
            // 
            this.txtKaynak.Enabled = false;
            this.txtKaynak.Location = new System.Drawing.Point(413, 30);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.Size = new System.Drawing.Size(239, 20);
            this.txtKaynak.TabIndex = 3;
            // 
            // txtHedef
            // 
            this.txtHedef.Enabled = false;
            this.txtHedef.Location = new System.Drawing.Point(413, 81);
            this.txtHedef.Name = "txtHedef";
            this.txtHedef.Size = new System.Drawing.Size(239, 20);
            this.txtHedef.TabIndex = 4;
            // 
            // btnHedef
            // 
            this.btnHedef.Location = new System.Drawing.Point(658, 81);
            this.btnHedef.Name = "btnHedef";
            this.btnHedef.Size = new System.Drawing.Size(75, 20);
            this.btnHedef.TabIndex = 5;
            this.btnHedef.Text = "Hedef Seç";
            this.btnHedef.UseVisualStyleBackColor = true;
            this.btnHedef.Click += new System.EventHandler(this.btnHedef_Click);
            // 
            // Kopyala
            // 
            this.Kopyala.Location = new System.Drawing.Point(413, 142);
            this.Kopyala.Name = "Kopyala";
            this.Kopyala.Size = new System.Drawing.Size(75, 23);
            this.Kopyala.TabIndex = 6;
            this.Kopyala.Text = "Kopyala";
            this.Kopyala.UseVisualStyleBackColor = true;
            this.Kopyala.Click += new System.EventHandler(this.button3_Click);
            // 
            // TumunuKopyala
            // 
            this.TumunuKopyala.Enabled = false;
            this.TumunuKopyala.Location = new System.Drawing.Point(541, 142);
            this.TumunuKopyala.Name = "TumunuKopyala";
            this.TumunuKopyala.Size = new System.Drawing.Size(111, 23);
            this.TumunuKopyala.TabIndex = 7;
            this.TumunuKopyala.Text = "Tümünü Kopyala";
            this.TumunuKopyala.UseVisualStyleBackColor = true;
            this.TumunuKopyala.Click += new System.EventHandler(this.TumunuKopyala_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(253, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Sadece Test Klasörü İçerisinde Bulunanları Tara";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dosya Türünü Seç",
            ".doc",
            ".html",
            ".iso",
            ".jpg",
            ".mp3",
            ".mp4",
            ".pdf",
            ".rar",
            ".txt",
            ".xlsx",
            ".zip"});
            this.comboBox1.Location = new System.Drawing.Point(38, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 198);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TumunuKopyala);
            this.Controls.Add(this.Kopyala);
            this.Controls.Add(this.btnHedef);
            this.Controls.Add(this.txtHedef);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.btnKaynak);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Tarama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKaynak;
        private System.Windows.Forms.TextBox txtKaynak;
        private System.Windows.Forms.TextBox txtHedef;
        private System.Windows.Forms.Button btnHedef;
        private System.Windows.Forms.Button Kopyala;
        private System.Windows.Forms.Button TumunuKopyala;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

