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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\kullanici.accdb");

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.MdiParent = this.ParentForm;
            f7.Show();
        }

        int count = 3;
        bool sit = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(count!=0)
            {
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select * from parola", baglanti);
                OleDbDataReader oku = sorgu.ExecuteReader();
                while(oku.Read())
                {
                    if (oku ["kullanici_adi"].ToString()==textBox1.Text&&oku ["parola"].ToString()==textBox2.Text)
                    {
                        sit = true;
                        Form1 f1 = new Form1();
                        f1.Show();
                        break;
                    }
                }
                if (sit == false)
                {
                    count--;
                }
                    baglanti.Close();
                
            }
            if (count==0)
            {
                button1.Enabled = false;
                MessageBox.Show("Kullanıcı adı şifre kombinasyonunu 3 kez yanlış girdiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                    
            }
        }
        
        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "Kullanıcı Girişi...";
            this.AcceptButton = button1;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Italic);
            textBox2.PasswordChar = '*';
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
