// Сформировать массив со строками, длина которых не более трех символов 
// на основе заданного массива

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string[] setArray(string[] array)
{
    int len = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            len++;
        }
    }

    int index = 0;
    string[] newArray = new string[len];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }

    return newArray;
}

//string[] arrayStr = { "hello", "2", "world", ":-)" };
string[] arrayStr = { "1234", "1657", "-2", "computer science" };
PrintArray(arrayStr);
string[] newArrayStr = setArray(arrayStr);
PrintArray(newArrayStr);