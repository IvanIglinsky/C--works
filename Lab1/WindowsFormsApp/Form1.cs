using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            Program.automated.Adressa[0] = "Київ,Київська 105";
            Program.automated.Adressa[1] = "Житомир,Чуднівська 100";
            Program.automated.Adressa[2] = "Житомир,Київська 11";
            Program.automated.idBank[0] = 10;
            Program.automated.idBank[1] = 62;
            Program.automated.idBank[2] = 95;
            int n = 3;     
            Program.automated.Count = comboBox1.SelectedIndex;
            for (int i = 0; i < n; i++)
            {
                Program.bank.NameBank = comboBox1.Items[i].ToString();
                Program.bank.ListBank[i] = Program.bank.NameBank;
                Program.automated.AllMoney[i] = random.Next(1000, 100000);   
            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n =comboBox1.SelectedIndex;
            MessageBox.Show("Назва банкомату:" + Program.bank.ListBank[n] + "\nid-Банкомату:" + Program.automated.idBank[n] + "\nАдреса:" + Program.automated.Adressa[n]);  
        }
        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ваш баланс: "+Program.account.balance+" грн.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();

        }
    }
}
