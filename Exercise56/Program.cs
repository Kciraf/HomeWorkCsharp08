// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int NumInput(string Text)
{
    System.Console.Write(Text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void LowlestLine(int[,] matrix)
{
    int[] lineSum = new int[matrix.GetLength(0)];
    int numLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            lineSum[i] += matrix[i, j];
        }
    }
    for (int i = 1; i < lineSum.Length; i++)
    {
        if (lineSum[i] < lineSum[numLine]) numLine = i;
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой: {numLine + 1}");
}

int m = NumInput("Введите количество строк: ");
int n = NumInput("Введите количество столбцов: ");
int[,] myMatrix = CreateMatrix(m, n);
PrintMatrix(myMatrix);
LowlestLine(myMatrix);

