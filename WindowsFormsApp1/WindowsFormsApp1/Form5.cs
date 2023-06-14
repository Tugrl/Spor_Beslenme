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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\besin_degerleri.accdb");
        private void Form5_Load(object sender, EventArgs e)
        {
            kayitlistele();
        }
        private void kayitlistele()
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from besin", baglanti);
                DataSet dshafiza = new DataSet();
                listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand kaydet = new OleDbCommand("insert into besin(Besinler,Kcal)values('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Kaydedildi...", "Veri Tabanı İşlemleri");

            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri Tabanı İşlemleri");
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter search = new OleDbDataAdapter("select * from besin where besinler = '" + textBox1.Text + "'", baglanti);
                DataSet dshafiza = new DataSet();
                search.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
                baglanti.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from besin", baglanti);
                DataSet mem = new DataSet();
                listele.Fill(mem);
                dataGridView1.DataSource = mem.Tables[0];
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                baglanti.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
