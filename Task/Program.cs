
string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string Print(string[] arr)
{
    string result = $"[{string.Join(", ", arr)}]";
    return result;
}

Console.WriteLine(Print(array1));