using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            comboBox5.SelectedIndex = 1;
            comboBox4.SelectedIndex = 1;
            comboBox3.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kapı Açıldı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kapı Kapandı.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yaptığınız İşlemler Başarıyla Gerçekleştirildi.");
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
                {
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox6.Enabled = false;
            }
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                comboBox10.Enabled = true;
            }
            else
            {
                comboBox10.Enabled = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                comboBox9.Enabled = true;
            }
            else
            {
                comboBox9.Enabled = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                comboBox8.Enabled = true;
            }
            else
            {
                comboBox8.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox7.Enabled = true;
            }
            else
            {
                comboBox7.Enabled = false;
            }
        }
    }
}
