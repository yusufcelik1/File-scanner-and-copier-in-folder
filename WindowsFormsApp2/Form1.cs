using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        #region PDF Listeme
        private string[] dirs;
        private string[] files;
        private System.IO.FileInfo file;
        private void GetDocument(string path, ref List<string> listPDF)
        {
            string uzanti = comboBox1.SelectedItem.ToString();
            try
            {
                dirs = System.IO.Directory.GetDirectories(path);
                foreach (string item in dirs)
                {
                    GetDocument(item, ref listPDF);
                }
                files = System.IO.Directory.GetFiles(path);
                foreach (string item in files)
                {
                    file = new System.IO.FileInfo(item);
                    if (checkBox1.Checked == true)
                    {
                        if (file.DirectoryName.ToLower().EndsWith("test") && file.Extension.ToLower() == uzanti)
                        {
                            listPDF.Add(file.FullName);
                        }
                    }
                    else
                    {
                        if (file.Extension.ToLower() == uzanti)
                        {
                            listPDF.Add(file.FullName);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                string dialog = txtKaynak.Text;
                List<string> listPDF = new List<string>();
                GetDocument(dialog, ref listPDF);
                listPDF.Sort();
                foreach (string filePath in listPDF)
                {
                    listBox1.Items.Add(filePath);
                }
                TumunuKopyala.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen öncelikle kaynak dosya seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Dosya Kopyalama
        private void button2_Click(object sender, EventArgs e)
        {
            txtKaynak.Text = "";
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtKaynak.Text = Path.Combine(dialog.SelectedPath, Path.GetFileName(txtKaynak.Text));
            }
        }
        private void btnHedef_Click(object sender, EventArgs e)
        {
            txtHedef.Text = "";
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtHedef.Text = Path.Combine(dialog.SelectedPath, Path.GetFileName(txtHedef.Text));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Öncelikle Kopyalamak istediğiniz dosyayı seçiniz" , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FileInfo fileInfo = new FileInfo(listBox1.SelectedItem.ToString());
                File.Copy(fileInfo.ToString(), txtHedef.Text + @"\" + fileInfo.Name, true);
                MessageBox.Show("Seçilen dosya başarıyla kopyalandı. Dosya adı:" + fileInfo.Name, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TumunuKopyala_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 0 || txtHedef.Text != "")
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, true);
                    FileInfo fileInfo = new FileInfo(listBox1.SelectedItem.ToString());
                    File.Copy(fileInfo.ToString(), txtHedef.Text + @"\" + fileInfo.Name, true);
                }
                MessageBox.Show("Seçilen dosya başarıyla kopyalandı.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items[0].ToString();
        }
    }
}


