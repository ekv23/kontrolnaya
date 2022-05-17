// Задание: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Пример: ["hello", "2", "world", ":-)"]  ->  ["2", ":-)"]


// метод выводит первоначальный массив
void PrintInitArray(string[] array)
{
    Console.Write("вот такой массив: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

// метод обрабатывает первоначальный массив и выводит обработанный массив 
//в соответсвии с условиями задачи:
string[] CreateResult(string[] array, int lim)
{
    int size = array.Length;
    string[] finalArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= lim) finalArray[i] = array[i];
        else finalArray[i] = string.Empty;
    }
    return finalArray;
}