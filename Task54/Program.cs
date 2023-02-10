// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

int[,] DescendingRows(int[,] matrix)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(0) - 1; k++)
        {


            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[j, i] < matrix[j, i + 1])
                {
                    int max = matrix[j, i + 1];
                    matrix[j, i + 1] = matrix[j, i];
                    matrix[j, i] = max;
                }

            }
        }
    }

    return matrix;
}


int[,] mtx = GenerateMatrix(4, 4, 0, 9);
PrintMatrix(mtx);
Console.WriteLine();
DescendingRows(mtx);
PrintMatrix(mtx);

