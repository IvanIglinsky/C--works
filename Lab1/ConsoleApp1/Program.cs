using ClassLibrary;
using System.Net.Mail;
using System.Net;
using System.Text;
using static System.Console;
using System.Runtime.InteropServices;

Account account = new Account();
 Bank bank = new Bank();
 AutomatedTellerMachine automated = new AutomatedTellerMachine();

OutputEncoding =Encoding.Unicode;
WriteLine("Виберіть пункт:");
WriteLine("1-Вхід");
WriteLine("2-Реєстрація");
WriteLine("3-Вийти");

int n = 0;

n=Int32.Parse( ReadLine());
switch(n)
{
    case 1:
        WriteLine("Введіть номер карти:");
        account.numberCard= Int32.Parse(ReadLine());
        WriteLine("Введіть пін-код:");
        account.pincode= Int32.Parse(ReadLine());
        break;
    case 2:
        WriteLine("Введіть Ім'я:");
        account.name=ReadLine();
        WriteLine("Введіть Прізвище:");
        account.surname = ReadLine();
        WriteLine("Введіть Почту:");
        string email = ReadLine();
        int pin = account.GenPin();
        int number =account.GenNewNumber();
        var smtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("ipz214_iiyu@student.ztu.edu.ua", "205047"),
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network
        };
        smtpClient.Send("ipz214_iiyu@student.ztu.edu.ua", email, "Аутентифікація", "Шановний:" + account.name + " " + account.surname + "\nНомер вашої карти:" + number + "\nПароль:" + pin);
        account.account(account.name, account.surname, number, pin);
        WriteLine("Лист аутентифікації відправлено");
        break;
    case 3:
        Environment.Exit(0);
        break;


}
Clear();
bool fl = true;

do
{

WriteLine("Виберіть пункт:\n");
WriteLine("1-Зняття коштів");
WriteLine("2-Перегляд балансу на карті");
WriteLine("3-Зарахування коштів на картку");
WriteLine("4-Перерахування коштів на картку");
WriteLine("5-Інформація про банкомат");
n = Int32.Parse(ReadLine());

switch (n)
{
    case 1:
        WriteLine("Введіть суму для зняття:");
        float sum = float.Parse(ReadLine());
        account.Take(sum);
        WriteLine("Суму (" + sum + ") успішно знято");
        break;
    case 2:
        WriteLine("Ваш баланс:" + account.balance + "грн.");
        break;
    case 3:
        WriteLine("Введіть суму для зарахування:");
        float SumToAdd = float.Parse(ReadLine());
        account.balance += SumToAdd;
        WriteLine("Переказ успішно зарахований");
        break;
    case 4:
        WriteLine("Введіть карту для зарахування:");
        int NumC = Int32.Parse(ReadLine());
        WriteLine("Введіть суму для зарахування:");
        float SumC = float.Parse(ReadLine());
        if (account.numberCard == NumC)
        {
            account.Add(SumC);
            WriteLine("На карту:  " + NumC + "  зараховано переказ в розмірі:   " + SumC + " грн.");
        }
        else
            WriteLine("Карту не знайдено");
        break;
    case 5:
        Random random = new Random();
        automated.Adressa[0] = "Київ,Київська 105";
        automated.Adressa[1] = "Житомир,Чуднівська 100";
        automated.Adressa[2] = "Житомир,Київська 11";
        automated.idBank[0] = 10;
        automated.idBank[1] = 62;
        automated.idBank[2] = 95;
        int tm = 3;
        for (int i = 0; i < tm; i++)
        {
            bank.ListBank[i] = bank.NameBank;
            automated.AllMoney[i] = random.Next(1000, 100000);
        }
            int tmps = 0;
            WriteLine("Введіть номер банку(1-3)");
        tmps=Int32.Parse( ReadLine());
            WriteLine("Банк № " + tmps + " знаходиться за адресою: " + automated.Adressa[tmps] + " та має ID:" + automated.idBank[tmps]);
        break;
    }
    WriteLine("Бажаєте продовжити?");
    WriteLine("1-Tak");
    WriteLine("2-Ні");
    int tmp = 0;
    tmp = Int32.Parse(ReadLine());
    if (tmp == 1) fl = true;
    if (tmp == 2) fl = false;
    Clear();
} while (fl == true);