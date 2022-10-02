//Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

Console.Clear();

int height = EnterInt("Введите количество строк: ");
int width = EnterInt("Введите количество столбцов: ");

double[,] matrix = FillMatrix(height, width);
PrintMatrix(matrix);

int EnterInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

double[,] FillMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() * 10, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


