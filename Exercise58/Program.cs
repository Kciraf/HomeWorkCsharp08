// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[] SizeInput(string Text)
{
    System.Console.Write(Text);
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
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

int[,] MatrixMultipl(int[,] matrA, int[,] matrB)
{
    int[,] result = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrA.GetLength(1); j++)
        {
            for (int j2 = 0; j2 < matrB.GetLength(1); j2++)
            {
                result[i, j2] = result[i, j2] + matrA[i, j] * matrB[j, j2];
            }
        }
    }
    return result;
}

int[] size1 = SizeInput("Введите размер матрицы 1: "),
    size2 = SizeInput("Введите размер матрицы 2: ");

int[,] matrix1 = CreateMatrix(size1[0], size1[1]);
int[,] matrix2 = CreateMatrix(size2[0], size2[1]);

PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0)) PrintMatrix(MatrixMultipl(matrix1, matrix2));
else System.Console.WriteLine($"Матрицы нельзя умножить!");
