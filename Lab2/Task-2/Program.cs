using System.Text;
using static System.Console;

Encoding Encoding = Encoding.UTF8;
OutputEncoding = Encoding.UTF8;
Dictionary<int, Dictionary<string, string>> dictd = new Dictionary<int, Dictionary<string, string>>();
dictd.aDD<int, string, string>(1, "123", "467");
bool Tf = true;
while (Tf == true)
{
    WriteLine("Виберіть пункт меню:");
    WriteLine("1-Додавання елемента");
    WriteLine("2-Видалення елемента");
    WriteLine("3-Перевірка наявності елемента із заданим ключем");
    WriteLine("4-Перевірка наявності елемента із заданим значенням (значення1 та значення2)");
    WriteLine("5-Повернення елемента за заданим ключем (реалізувати операцію індексування)");
    WriteLine("6-Кількість елементів");
    WriteLine("7-Виведення елементів за допомогую foreach");
    int n = Int32.Parse(ReadLine());
    switch (n)
    {
        case 1:
            WriteLine("Введіть елементи для додавання");
            dictd.aDD<int, string, string>(Int32.Parse(ReadLine()), ReadLine(), ReadLine());
            break;
        case 2:
            WriteLine("Введіть елемент для видалення(id)");
            int id = Int32.Parse(ReadLine());
            dictd.REMOVE(id);
            WriteLine("Елемент з id-{0} успішно видалено", id);
            break;
        case 3:
            WriteLine("Введіть ключ для перевірки:");
            dictd.CheckInKey(Int32.Parse(ReadLine()));
            break;
        case 4:
            WriteLine("Введіть значення 1 та значення 2 для перевірки:");
            int value1 = Int32.Parse(ReadLine());
            string value2 = ReadLine();
            dictd.ChekWORDinVALUE<int, string, string>(value1, value2);
            break;
        case 5:
            WriteLine("Введіть елемент для повернення(id)");
            dictd.GetElemen(Int32.Parse(ReadLine()));
            break;
        case 6:
            Write("Кількість елементів:{0}", dictd.CountElem());
            break;
        case 7:
            for (var i = 1; i <= dictd.CountElem(); i++)
            {
                foreach (var dict in dictd[i])
                    WriteLine(dict);
            }
            break;
    }
    WriteLine("\nБажаєте продовжити?(1-так,2-ні)");
    int r = Int32.Parse(ReadLine());
    if (r == 1)
        Tf = true;
        Clear();
    if (r == 2)
        Tf = false;
}
public  class Dict<T, U, V>
{
    public T idKey { get; set; }
    public U FirstValue { get; set; }
    public V SecondValue { get; set; }
}

public static class ExtendedDictionary
{
    public static void aDD<T, U, V>(this Dictionary<T, Dictionary<U, V>> dict, T id, U value1, V value2)
    {
        var dicts =new Dictionary<U, V>();
        dicts.Add(value1, value2);
        dict.Add(id,dicts);
    }
    public static void REMOVE<T,U,V>(this Dictionary<T,Dictionary<U,V>> dict,T id)
    {
        dict.Remove(id);
    }
    public static void CheckInKey<T,U,V>(this Dictionary<T,Dictionary<U,V>> dictonart,T t)
    {
       if( dictonart.ContainsKey(t))
        {
            WriteLine("Елемент з id-{0} є в словникиу", t);
        }
        else
            WriteLine("Елемента з id-{0} немає в словнику", t);
    }
    public static void ChekWORDinVALUE<T, U, V>(this Dictionary<T, Dictionary<U,V>> dictionary,T t, V value2)
    {
        if (dictionary[t].ContainsValue(value2))
        {
            WriteLine("Елемент {0} є в словникиу", value2);
        }
        else
            WriteLine("Елемента {0} немає в словнику", value2);
    }
    public static void GetElemen<T, U, V>(this Dictionary<T, Dictionary<U, V>> dictionary, T t)
    {
        WriteLine(dictionary[t]);
    }
    public static int CountElem<T, U, V>(this Dictionary<T, Dictionary<U, V>> dictionary)
    {
        return dictionary.Count;
    }
}

/*
    public static string[] ADD<idKey, FirstValue, SecondValue>(this Dict<idKey, FirstValue, SecondValue> dict, idKey id, FirstValue value1, SecondValue value2)
    {
        string[] dicts = new string[3];
        dicts[0] = id.ToString();
        dicts[1] = value1.ToString();
        dicts[2] = value2.ToString();
        return dicts;
        
    }
    public static void REMOVE<idKey, FirstValue, SecondValue>(this Dict<idKey, FirstValue, SecondValue> dict, idKey id)
    {
        
    }
    public static void AddFormat<TKey>(this Dictionary<TKey, string> dictionary,
    TKey key,
    string formatString,
    params object[] argList)
    {
        dictionary.Add(key, string.Format(formatString, argList));
    }

       public static void AddWORD<TKey, Dict,Dict2>(this Dictionary<TKey, Dict> dictionary,
     TKey key,
     Dict dict,
     Dict2 dict2,
     params object[] argList)
    {
        string word = " ";
        word+= dict.ToString();
        word+= dict2.ToString();
        dictionary.Add(key);       
    }
  

    public static void RemoveWORD<TKey>(this Dictionary<TKey, string> dictionary,TKey key)
    {
        dictionary.Remove(key);

    }
    public static string ChekWORDinKEY<TKey>(this Dictionary<TKey, string> dictionary,TKey key)
    {
        if( dictionary.ContainsKey(key))
        {
            return "Yes";
        }    
        else
        {
            return "No";
        }
    }
    public static string ChekWORDinVALUE<TKey,U,V>(this Dictionary<TKey, string> dictionary,U value1,V value2)
    {
        return value1.ToString()+" - "+ dictionary.ContainsValue(value1.ToString())+"\n"+
                value2.ToString()+" - "+ dictionary.ContainsValue(value2.ToString());
    }
    public static string GetWordInKEY<TKey>(this Dictionary<TKey, string> dictionary,TKey T)
    {
         return dictionary[T];
    }
    public static int CountD<TKey>(this Dictionary<TKey,string> dictionary)
    {
        return dictionary.Count;
    }    
}

public static class ExtendedDicrionaryElement
{
    class Element<T, U, V> {
        public U Value1 { get; set; }
        public V Value2 { get; set; }
        public T idKey { get; set; }
    }
}
*/