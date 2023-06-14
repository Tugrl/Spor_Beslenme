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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, boyun, bel, kalca;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);


            boyun = Convert.ToDouble(textBox3.Text);
            bel = Convert.ToDouble(textBox4.Text);

            if (textBox5.Text != "")
            {
                kalca = Convert.ToDouble(textBox5.Text);
                double yag = (495 / (1.29579 - 0.35004 * Math.Log10(bel + kalca - boyun) + 0.22100 * Math.Log10(boy)) - 450);
                textBox6.Text = yag.ToString("0.##");
                string yag2 = Convert.ToString(yag);
                //f1.textBox6.Text = textBox6.Text;
            }
            else
            {
                double yag = (495 / (1.0324 - 0.19077 * Math.Log10(bel - boyun) + 0.15456 * Math.Log10(boy))) - 450;
                textBox6.Text = yag.ToString("0.##");
                string yag2 = Convert.ToString(yag);
                //f1.textBox6.Text = textBox6.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double kilo, yag;
                kilo = Convert.ToDouble(textBox2.Text);
                yag = Convert.ToDouble(textBox6.Text);
                double yagsizkütle;
                yagsizkütle = kilo * (1 - (yag / 100));
                textBox7.Text = yagsizkütle.ToString("0.##");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double kilo, yag;
                kilo = Convert.ToDouble(textBox2.Text);
                yag = Convert.ToDouble(textBox6.Text);
                double yagsizkütle;
                yagsizkütle = kilo * (1 - (yag / 100));
                double bazalmet;
                bazalmet = 370 + (21.6 * yagsizkütle);
                textBox8.Text = bazalmet.ToString("0.##");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton6.Checked == true)
                {
                    if (textBox10.Text != "")
                    {
                        double spor_kalori;
                        spor_kalori = Convert.ToDouble(textBox10.Text);
                        if (radioButton1.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.2 + spor_kalori - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton2.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.375 + spor_kalori - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton3.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.55 + spor_kalori - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton4.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.725 + spor_kalori - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton5.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.9 + spor_kalori - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                    }
                    else
                    {

                        if (radioButton1.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.2 - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton2.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.375 - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton3.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.55 - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton4.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.725 - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton5.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.9 - 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                    }
                }
                else if (radioButton7.Checked == true)
                {
                    if (textBox10.Text != "")
                    {
                        double spor_kalori;
                        spor_kalori = Convert.ToDouble(textBox10.Text);
                        if (radioButton1.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.2 + spor_kalori;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton2.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.375 + spor_kalori;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton3.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.55 + spor_kalori;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton4.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.725 + spor_kalori;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton5.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.9 + spor_kalori;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                    }
                    else
                    {

                        if (radioButton1.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.2;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton2.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.375;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton3.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.55;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton4.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.725;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton5.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.9;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                    }
                }
                else if (radioButton8.Checked == true)
                {
                    if (textBox10.Text != "")
                    {
                        double spor_kalori;
                        spor_kalori = Convert.ToDouble(textBox10.Text);
                        if (radioButton1.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.2 + spor_kalori + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton2.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.375 + spor_kalori + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton3.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.55 + spor_kalori + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton4.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.725 + spor_kalori + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton5.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.9 + spor_kalori + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                    }
                    else
                    {

                        if (radioButton1.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.2 + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton2.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.375 + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton3.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.55 + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton4.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.725 + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                        else if (radioButton5.Checked == true)
                        {
                            double kilo, yag;
                            kilo = Convert.ToDouble(textBox2.Text);
                            yag = Convert.ToDouble(textBox6.Text);
                            double yagsizkütle;
                            yagsizkütle = kilo * (1 - (yag / 100));
                            double bazalmet;
                            bazalmet = 370 + (21.6 * yagsizkütle);
                            double yakılan_kalori = bazalmet * 1.9 + 500;
                            textBox9.Text = yakılan_kalori.ToString("0.##");
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = null;
            textBox5.Font = new Font(textBox5.Font, textBox5.Font.Style ^ FontStyle.Italic);
        }
    }
}
