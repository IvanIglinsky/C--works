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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int pin = Program.account.GenPin();
            int number=Program.account.GenNewNumber();
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("ipz214_iiyu@student.ztu.edu.ua", "205047"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send("ipz214_iiyu@student.ztu.edu.ua", textBox1.Text, "Аутентифікація", "Шановний:"+textBox3.Text+" "+textBox2.Text+"\nНомер вашої карти:" + number+"\nПароль:"+pin);
           Program.account.account(textBox3.Text, textBox2.Text, number, pin);
            MessageBox.Show("Лист аутентифікації відправлено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
