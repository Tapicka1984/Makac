using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        zamestnanec zamestnanec;
        Nadrizeny nadrizeny;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text != string.Empty) || (textBox2.Text != string.Empty) || (textBox3.Text != string.Empty) || (textBox5.Text != string.Empty))
                {
                    if(radioButton1.Checked)
                    {
                        nadrizeny = new Nadrizeny(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), dateTimePicker1.Value, int.Parse(textBox5.Text));
                    }
                    else
                    {
                        zamestnanec = new zamestnanec(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), dateTimePicker1.Value, int.Parse(textBox5.Text));
                    }
                }
                else
                {
                    MessageBox.Show("zadej do nás něco");
                }
                button1.Visible = false;
                button2.Visible = true;
            }
            catch
            {
                MessageBox.Show("zkontrolujte formaty vstupů prosím");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show(nadrizeny.info());
            }
            else
            {
                MessageBox.Show(zamestnanec.info());
            }
            button1.Visible = true;
            button2.Visible = false;
        }
    }
}
