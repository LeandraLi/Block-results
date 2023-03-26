//Проверяем заданный массив на трёхзначные символы:
string[] GenArray(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

//Создание массива с тремя символами:
string[] newArray = new string[count]; 
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

//Печать массива
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

//Выбираем один из массивов для ввода:
string[] array = { "1234", "1567", "-2", "computer science" };
//string[] array = { "Russia", "Denmark", "Kazan" };
//string[] array = { "hello", "2", "world", ":-)" };

Console.WriteLine();
Console.Write("Задан массив: ");
PrintArray(array);

string[] newarray = GenArray(array);
Console.Write("Новый массив с <= 3 символами: ");
PrintArray(newarray);
Console.WriteLine();