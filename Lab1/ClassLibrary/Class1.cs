using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Account
    {
        private string Name;
        private string Surname;
        private float _balance;
        private int NumberCard;
        private int Pincode;
    
        public void Add(float sum) => this.balance += sum;
        public void Take(float sum)
        {
             this.balance -= sum;
          
        }
       
        public string name
        {
            set { this.Name = value; }
            get => Name;

        }
        public string surname
        {
            set { this.Surname = value; }
            get { return this.Surname; }
        }
        public int numberCard
        {
            set { this.NumberCard = value; }
            get { return this.NumberCard; }


        }
        
        public float balance
        {
            set { _balance = value; }
            get { return _balance; }
        }
        public int pincode
            {
            set { this.Pincode = value; }
            get { return this.Pincode; }
            }

        public void account(string name,string surname,int numberCard,float balance)
        {
            this.name = name;
            this.surname = surname;
            this.numberCard = numberCard;
            this.balance = balance;
        }
        public int GenPin()
        {
            Random random = new Random();
            pincode = random.Next(1000, 9999);
            return pincode;
        }
        public int GenNewNumber()
        {
            Random random=new Random();
            numberCard = random.Next(1000000, 9999999);
            return numberCard;
        }
    }
    
    public class AutomatedTellerMachine
    {
       public int Count=0;
       public static int n = 3;
       public float[] AllMoney = new float[n];
       public float[] idBank = new float[n];
       public string[] Adressa = new string[n];
    }
    public class Bank
    {
       public string NameBank = "";
       public string[] ListBank=new string[3];

    }


}
