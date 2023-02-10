// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }

        }
    }
    return result;
}

int[,] mtx1 = GenerateMatrix(2, 3, 0, 9);
int[,] mtx2 = GenerateMatrix(3, 2, 0, 9);
if (mtx1.GetLength(1) == mtx2.GetLength(0))
{
    int[,] matrixMultiplication = MatrixMultiplication(mtx1, mtx2);
    PrintMatrix(mtx1);
    Console.WriteLine();
    PrintMatrix(mtx2);
    Console.WriteLine();
    PrintMatrix(matrixMultiplication);
}
else Console.WriteLine("Матрицы нельзя перемножить");