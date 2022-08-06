int requiredLength = 3;
string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string Print(string[] arr)
{
    string result = $"[{string.Join(", ", arr)}]";
    return result;
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

Console.WriteLine(Print(array1));