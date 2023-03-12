// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] FixLineMatrix(int[,] matrix)
{
    int maxTemp = matrix[0,0];  //Промежуточная переменная для сравнения
    int tempj = 0;      // Временая переменная цикла для уменьшения итераций
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        tempj = 0;    
        while(tempj < matrix.GetLength(1))
        {
            maxTemp = matrix[i,tempj];
            for (int j = tempj; j < matrix.GetLength(1); j++)
            {
                if(matrix[i, j] > maxTemp)
                {
                    maxTemp = matrix[i, j];
                    matrix[i, j] = matrix[i, tempj];
                    matrix[i, tempj] = maxTemp;
                }
            }
            tempj++;
        }
    }
    return matrix;
}

int m = NumInput("Введите количество строк: ");
int n = NumInput("Введите количество столбцов: ");
int[,] myMatrix = CreateMatrix(m,n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(FixLineMatrix(myMatrix));