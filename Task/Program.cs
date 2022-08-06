int requiredLength = 3;
string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string Print(string[] arr)
{
    string result = $"[{string.Join(", ", arr)}]";
    return result;
}

string[] Create()
{
    Console.WriteLine("Введите число - длина массива:");
    int len = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[len];
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int GetCountShortStrings(string[] arr, int reqLength)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= reqLength) count++;
    }
    return count;
}

string[] GetShortStrings(string[] arr, int reqLength)
{
    int count = GetCountShortStrings(arr, reqLength);
    string[] outputArray = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= reqLength)
        {
            outputArray[j] = arr[i];
            j++;
        }
    }
    return outputArray;
}

Console.WriteLine("Тестовые примеры");
Console.WriteLine(Print(array1));
string[] result1 = GetShortStrings(array1, requiredLength);
Console.WriteLine($"Элементы массива, длина которых меньше либо равна {requiredLength}:");
Console.WriteLine(Print(result1));
Console.WriteLine();
Console.WriteLine(Print(array2));
string[] result2 = GetShortStrings(array2, requiredLength);
Console.WriteLine($"Элементы массива, длина которых меньше либо равна {requiredLength}:");
Console.WriteLine(Print(result2));
Console.WriteLine();
Console.WriteLine(Print(array3));
string[] result3 = GetShortStrings(array3, requiredLength);
Console.WriteLine($"Элементы массива, длина которых меньше либо равна {requiredLength}:");
Console.WriteLine(Print(result3));
Console.WriteLine();

Console.WriteLine("Пользовательский ввод элементов массива");
string[] myArray = Create();
Console.WriteLine(Print(myArray));
string[] result4 = GetShortStrings(myArray, requiredLength);
Console.WriteLine($"Элементы массива, длина которых меньше либо равна {requiredLength}:");
Console.WriteLine(Print(result4));