using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5=new Form5();
            this.Hide();
            form5.ShowDialog();
         
         
        }
        private void button3_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Form6 form6=new Form6();
            this.Hide();
            form6.ShowDialog();
          
        }
    }
}
