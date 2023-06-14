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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\proje.accdb");
        //OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\kullanici.accdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            //Form6 f6 = new Form6();
            kayitlistele();
            //baglanti2.Open();
            //OleDbCommand sorgu = new OleDbCommand("select * from parola", baglanti2);
            //OleDbDataReader oku = sorgu.ExecuteReader();
            //while (oku.Read())
            //{
            //    if (oku["kullanici_adi"].ToString() == f6.textBox1.Text && oku["parola"].ToString() == f6.textBox2.Text)
            //    {
            //        //sit = true;

            //        break;
            //    }

            // TODO: Bu kod satırı 'projeDataSet1.proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.projeTableAdapter1.Fill(this.projeDataSet1.proje);
            // TODO: Bu kod satırı 'projeDataSet.proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.projeTableAdapter.Fill(this.projeDataSet.proje);

            //listView1.Columns.Add("AD", 150);
            //listView1.Columns.Add("SOYAD", 150);
            //listView1.Columns.Add("YAS", 150);
            //listView1.Columns.Add("BOY", 150);
            //listView1.Columns.Add("KİLO", 150);
            //listView1.Width = 800;
        }
        public string global_yag;
        private void kayitlistele()
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from proje", baglanti);
                DataSet memory = new DataSet();
                listele.Fill(memory);
                dataGridView2.DataSource = memory.Tables[0];
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                baglanti.Close();
            }
            }
        private void endexmet()
        {
            try
            {
                string ad, soyad, yas, boy, kilo;
                ad = textBox1.Text;
                soyad = textBox2.Text;
                yas = textBox3.Text;
                boy = textBox4.Text;
                kilo = textBox5.Text;

                double boy2, kilo2;
                boy2 = Convert.ToDouble(textBox4.Text) / 100;
                kilo2 = Convert.ToDouble(textBox5.Text);
                double endex = kilo2 / (boy2 * boy2);
                string endex2 = Convert.ToString(endex);
                label7.Text = endex2;
                if (endex >= 18.5 && endex <= 25)
                {


                    MessageBox.Show("Kilonuz tamamen normal.", "Vücut Kilo Endeksi");

                }
                else if (endex < 18.5)
                {
                    MessageBox.Show("İdeal kilonuzdan daha hafifsiniz.", "Vücut Kilo Endeksi");
                }
                else if (endex > 25)
                {
                    MessageBox.Show("İdeal kilonuzdan daha ağırsınız.", "Vücut Kilo Endeksi");
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
           
            //string ad, soyad, yas, boy, kilo;
            //ad = textBox1.Text;
            //soyad = textBox2.Text;
            //yas = textBox3.Text;
            //boy = textBox4.Text;
            //kilo = textBox5.Text;
            
            //double boy2, kilo2;
            //boy2 = Convert.ToDouble(textBox4.Text) / 100;
            //kilo2 = Convert.ToDouble(textBox5.Text);
            //double endex = kilo2 / (boy2 * boy2);
            //string endex2 = Convert.ToString(endex);
            //label7.Text = endex2;
            //if (endex>=18.5&&endex<=25)
            //{
                
                
            //        MessageBox.Show("Kilonuz tamamen normal.", "Vücut Kilo Endeksi");
                
            //}
            //else if (endex<18.5)
            //{
            //    MessageBox.Show("İdeal kilonuzdan daha hafifsiniz.", "Vücut Kilo Endeksi");
            //}
            //else if (endex>25)
            //{
            //    MessageBox.Show("İdeal kilonuzdan daha ağırsınız.", "Vücut Kilo Endeksi");
            //}
            //string yag = f2.label7.Text;
            //textBox6.Text = yag;
            //textBox6.Text = f2.textBox6.Text;
            //string[] bilgi = { ad, soyad, yas, boy, kilo,endex2 };
            //ListViewItem kayit = new ListViewItem(bilgi);
            //listView1.Items.Add(kayit);
            try
            {
                baglanti.Open();
                OleDbCommand kaydet = new OleDbCommand("insert into proje (Ad,Soyad,Yaş,Boy,Kilo,Vücut_kilo_endeksi)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+label7.Text+"')",baglanti);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Kaydedildi...", "Veri Tabanı İşlemleri");
                
            }
            catch(Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri Tabanı İşlemleri");
                baglanti.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.MdiParent = this.ParentForm;
            //f2.Show();
            //f2.textBox1.Text = textBox4.Text;
            //f2.textBox2.Text = textBox5.Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double boy ,kilo;
            boy = Convert.ToDouble(textBox4.Text)/100;
            kilo = Convert.ToDouble(textBox5.Text);
            double endex = kilo / (boy * boy);
            string endex2 = Convert.ToString(endex);
            label7.Text = endex2;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.MdiParent = this.ParentForm;
            f4.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this.ParentForm;
            f5.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label7.Text != "")
            {
                endexmet();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter search = new OleDbDataAdapter("select * from proje where Ad = '" + textBox1.Text + "'", baglanti);
                DataSet memory = new DataSet();
                search.Fill(memory);
                dataGridView2.DataSource = memory.Tables[0];
                baglanti.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
                baglanti.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter sil = new OleDbDataAdapter("delete from proje where Ad='" + textBox1.Text + "'", baglanti);
                DataSet memory = new DataSet();
                sil.Fill(memory);
                baglanti.Close();
                MessageBox.Show("Kayıt Silinmiştir...");
                kayitlistele();
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.Message);
                baglanti.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kayitlistele();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
