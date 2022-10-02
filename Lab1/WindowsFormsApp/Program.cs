using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Account account = new Account();
        public static Bank bank=new Bank();
        public static AutomatedTellerMachine automated=new AutomatedTellerMachine();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
    
            Application.Run(new Form4());
            

    }
    }
}
