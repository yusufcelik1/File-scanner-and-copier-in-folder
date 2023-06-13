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
    ///Contact
    ///Mail : yusufcancelik525@gmail.com
    ///github : github.com/yusufcelik1
    ///linkedin : www.linkedin.com/in/yusuf-can-celik/

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Dokuman Listeme
        private string[] dirs;
        private string[] files;
        private System.IO.FileInfo file;
        private void GetDocument(string path, ref List<string> listDocument)
        {
            // comboxBox1'de seçilen itemi uzantiya ata
            string uzanti = comboBox1.SelectedItem.ToString();
            try
            {

                dirs = System.IO.Directory.GetDirectories(path);
                foreach (string item in dirs)
                {
                    GetDocument(item, ref listDocument);
                }
                files = System.IO.Directory.GetFiles(path);
                //Test klasörü içerisinde bulan dosyaları tara tick'i aktif olduğunda sadece test klasörlerini tara
                foreach (string item in files)
                {
                    file = new System.IO.FileInfo(item);
                    if (checkBox1.Checked == true)
                    {
                        //Klasörlerin sonunda test ekleyerek, test klasörlerinin içini aramasını sağla
                        if (file.DirectoryName.ToLower().EndsWith("test") && file.Extension.ToLower() == uzanti)
                        {
                            listDocument.Add(file.FullName);
                        }
                    }
                    else
                    {
                        if (file.Extension.ToLower() == uzanti)
                        {
                            listDocument.Add(file.FullName);
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
                //Kaynak klasör seçilindikten sonra path isimlerini listbox'ta listele
                listBox1.Items.Clear();
                string dialog = txtKaynak.Text;
                List<string> listDocument = new List<string>();
                GetDocument(dialog, ref listDocument);
                listDocument.Sort();
                foreach (string filePath in listDocument)
                {
                    listBox1.Items.Add(filePath);
                }
                //Listelendikten sonra tümünü kopyalayı aktif et
                TumunuKopyala.Enabled = true;
            }
            catch (Exception)
            {
                //Eğer kaynak dosya seçilmezse uyarı ver
                MessageBox.Show("Lütfen öncelikle kaynak dosya seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Dosya Kopyalama
        private void button2_Click(object sender, EventArgs e)
        {
            //Kaynak klasörü seç
            txtKaynak.Text = "";
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //seçilen kaynak klasörü txtKaynak.Text'e yaz
                txtKaynak.Text = Path.Combine(dialog.SelectedPath, Path.GetFileName(txtKaynak.Text));
            }
        }
        private void btnHedef_Click(object sender, EventArgs e)
        {
            //hedef klasörü seç
            txtHedef.Text = "";
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //seçilen Hedef klasörü txtKaynak.Text'e yaz
                txtHedef.Text = Path.Combine(dialog.SelectedPath, Path.GetFileName(txtHedef.Text));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Sadece seçilen dosyayı kopyala
            if (listBox1.SelectedIndex == -1)
            {
                //Eğer dosya seçilmeden butona basılırsa uyarı ver
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
            //Tümünü kopyala
            //Eğer aynı isimde bir pdf varsa onları kopyalamadan üzerine yazar
            if (listBox1.Items.Count >= 0 || txtHedef.Text != "")
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, true);
                    FileInfo fileInfo = new FileInfo(listBox1.SelectedItem.ToString());
                    File.Copy(fileInfo.ToString(), txtHedef.Text + @"\" + fileInfo.Name, true);
                }
                //İşlem bittikten sonra bilgi ver
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


