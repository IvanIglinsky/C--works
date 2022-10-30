using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Console;

OutputEncoding = Encoding.Unicode;
WriteLine("Виберіть пункт меню:");
WriteLine("1-String");
WriteLine("2-Одновимірні масиви");
int n = Int32.Parse(ReadLine());
switch (n)
{
    case 1:
        {
            WriteLine("Введіть рядок:");
            string s = ReadLine();
            WriteLine("Інверсія:");
            if(s != null)
                WriteLine(s.InvertStr());
            WriteLine("Введіть символ для пошуку:");
            char a = (char)Read();
            WriteLine("Символ {0} має {1} входжень в рядок {2}", a, s.CharCount(a), s);
            break;
        }
    case 2:
        {
            WriteLine("Введіть кількість елементів в масиві:");
            int elem = Int32.Parse(ReadLine());
            WriteLine("Введіть масив:"); 
            string[] s = new string[elem];
            for (int i = 0; i < elem; i++)
            {
                s[i] = ReadLine().ToString();
           
            }
            WriteLine("Введіть значення для пошуку:");
            string search = ReadLine().ToString();
            WriteLine("В масиві  знайдено {0} елементів", s.CountElem(search));

            string[]str=new string[search.Length];
            str = s.Unikal();
            WriteLine("Унікальний масив:");
            for(int i=0;i<str.Length;i++)
                Write(str[i]+ " ");
            break;
        }
}


public static class StringExtension
{
    public static string InvertStr(this string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public static int CharCount(this string str, char c) 
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }
}

public static class Extension
{
    public static int CountElem<T>(this T[] arrays, T s) where T : class
    {
        int count = 0;
        for (int i = 0; i < arrays.Length; i++)
        {
            if (arrays[i] == s)
                ++count;
        }
        return count;
    }

    public static T[] Unikal<T>(this T[] str) where T:class
    {
        T[] strArray = new T[str.Length];
        for (int i = 1; i < str.Length; i++)
        {
                if (str[i] != str[i-1])
                {
                    strArray[i] = str[i];
                } 
        }
        return strArray;


    }
}


