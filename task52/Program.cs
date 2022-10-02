// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите число строк");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число столбцов ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);


void FillArray(int[ , ] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

