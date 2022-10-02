using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.account.numberCard == Int32.Parse(textBox1.Text))
            {
                Program.account.Add(float.Parse(textBox2.Text));
                MessageBox.Show("На карту:  " + textBox1.Text + "  зараховано переказ в розмірі:   " + textBox2.Text + " грн.");
            }
            else
                MessageBox.Show("Карту не знайдено");
        }
        }
}
