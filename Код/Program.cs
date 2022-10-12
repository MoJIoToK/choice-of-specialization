Console.Clear();
Console.Beep();

Console.WriteLine("ПЕРВЫЙ ВАРИАНТ РЕШЕНИЯ: ");
Console.WriteLine();
string[] strMas1_1 = { "hello", "2", "world", ":-)" };

Console.Write("Исходный массив - ");
Console.WriteLine(String.Join(" ", strMas1_1));

for (int i = 0; i < strMas1_1.Length; i++)
{
    if (strMas1_1[i].Length <= 3) Console.WriteLine(strMas1_1[i]);
    //else Console.WriteLine("Элемент имеет больше 3 символов");
}
///
///
///
Console.WriteLine();
Console.WriteLine("ВТОРОЙ ВАРИАНТ РЕШЕНИЯ: ");
Console.WriteLine();

string[] strMas2_1 = { "hello", "2", "world", ":-)"  }; //"Moscow", "Kazan", "Denmark"
string[] strMas2_2 = new string[strMas2_1.Length];

Console.Write("Исходный массив - ");
Console.WriteLine(String.Join(" ", strMas2_1));

int k = 0;

for (int i = 0; i < strMas2_1.Length; i++)
{
    if (strMas2_1[i].Length <= 3)
    {
        strMas2_2[k] = strMas2_1[i];
        k++;
    }
}

strMas2_2 = strMas2_2.Where(x => !string.IsNullOrEmpty(x)).ToArray();
Console.WriteLine(String.Join(",", strMas2_2));
//
//
//
Console.WriteLine();
Console.WriteLine("ТРЕТИЙ ВАРИАНТ РЕШЕНИЯ: ");
Console.WriteLine();

Console.WriteLine("Введите строки массива через запятую без пробелов (,): ");
string[] strMas3_1 = Console.ReadLine().Split(',');

int Test1(string[] sM)
{
    int count = 0;
    for (int i = 0; i < sM.Length; i++)
    {
        if (sM[i].Length <= 3) count++;
    }
    return count;
}

string[] GetArray(string[] sM, int len)
{
    string[] sM2 = new string[len];
    int j = 0;
    for (int i = 0; i < sM.Length; i++)
    {
        if (sM[i].Length <= 3)
        {
            sM2[j] = sM[i];
            j++;
        }
    }
    return sM2;
}

void PrintArray(string[] sM)
{
    if (sM.Length == 0) Console.WriteLine("Массив пуст");
    else Console.WriteLine(String.Join(",", sM));
}

int length = Test1(strMas3_1);
string[] strMas2 = GetArray(strMas3_1, length);
PrintArray(strMas2);
