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
// метод выводит обработанный массив
void PrintfinalArray(string[] array)
{
    Console.Write("вот, что получилось: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != string.Empty) Console.Write($"{array[i]}  ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

int limit = 3; //максимальное количество символов в строках выводимого массива по условиям задачи.

//в задачи разрешено либо использовать массив введенный вручную, либо уже имеющийся. 
//Выбран для решения задачи уже имеющийся массив. Пользователю предлагается посмотреть на имеющийся массив.

Console.WriteLine("Напишите 'да', чтобы увидеть первоначальный массив");
string answer = Console.ReadLine()!;

NewMethod(limit, answer);

void NewMethod(int limit, string answer)
{
    switch (answer)
    {
        case "да":
            {
                string[] arrayInit = { "hello", "2", "world", ":-)" };
                Console.WriteLine("Массив из примера задачи");
                PrintInitArray(arrayInit);
                Console.WriteLine();
                PrintfinalArray(CreateResult(arrayInit, limit));
                break;
            }
        default:
            {
                Console.WriteLine("Введено неверное значение. Приемлим только ответ 'да', отказаться невозможно :)");
                Console.WriteLine("Пожалуйста, запустите заново программу (необходимо ввести dontnet run) и напишите наконец 'да'");
                break;
            }
    }
}

