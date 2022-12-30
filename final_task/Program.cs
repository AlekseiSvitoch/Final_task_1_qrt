
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
//________________________________________________________________________________________

int length = 0;

int ArrayCount(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) length++;
    }
    return length;
}

void FillArray(string[] array1, string[] array2)
{
    int i = 0;
    int j = 0;
    while (i < array1.Length)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
        i++;
    }
}

Console.Clear();
string[] FirstArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2",
                    "computer science", "Russia", "Denmark", "Kazan", "FCK"};
Console.WriteLine("Первоначальный массив: ");
Console.WriteLine($"[{string.Join(", ", FirstArray)}]");
ArrayCount(FirstArray);
string[] ReliseArray = new string[length];
FillArray(FirstArray, ReliseArray); 
Console.WriteLine();
Console.WriteLine($"Массив с элементами меньше 3-х символов: ");
Console.WriteLine($"[{string.Join(", ", ReliseArray)}]");
if (length == 0)
    Console.WriteLine("В массиве нет элементов меньше 3-х символам");