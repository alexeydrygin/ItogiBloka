// Написать программ, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше или равна трем символам. 
//  Первоначальный массив задать с клавиатуры, 
//  лтбо задать на старте выполнения алгоритма.

string[] GenArray(string[] array) //Проверка исходного массива на 3х-значные символы
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newarray = new string[count]; //Создание массива с тремя символами
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

// Печать массива
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

// //Печатаем одномерный массив
// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(array[array.Length - 1], "]");
// }



// string[] array = { "1234", "1567", "-2", "computer science" };
// string[] array = { "Russia", "Denmark", "Kazan"};
string[] array = { "hello", "2", "world", ":-)" };


Console.WriteLine("Задан массив: ");
PrintArray(array);
Console.WriteLine();

string[] newarray = GenArray(array);
Console.WriteLine("В этом массиве символов <= 3: ");
PrintArray(newarray);
