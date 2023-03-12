// Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrix(int m, int n, int z)
{
    int[,,] matrix = new int[m, n, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int q = 0; q < matrix.GetLength(2); q++)
            {
                matrix[i, j, q] = new Random().Next(0, 11);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j, z]}({i},{j},{z})\t");
            }
            System.Console.WriteLine();
        }
    }
}

PrintMatrix(CreateMatrix(3, 3, 3));