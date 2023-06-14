using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\kullanici.accdb");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand kaydet = new OleDbCommand("insert into parola (kullanici_adi,parola)values('"+textBox3.Text+"','"+textBox4.Text+"')", baglanti);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni Kullanıcı Kaydedildi...", "Kullanıcı İşlemleri");

            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Kullanıcı İşlemleri");
                baglanti.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
