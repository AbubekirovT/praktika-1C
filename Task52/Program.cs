// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

string PrintArrayDouble(double[] arr)
{
    string array = ($"{Math.Round(arr[0],2)}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($"; {Math.Round(arr[i],2)}" );
    }
    return array;
}

double[] AverageColumns(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        average[j] = (double) sum / matrix.GetLength(0);
    }
    return average;
}

int[,] array2D = GenerateMatrix(3,4,0,9);
double[] averageColumns = AverageColumns(array2D);
PrintMatrix(array2D);
Console.WriteLine($"Среднее арифметическое каждого столбца: {PrintArrayDouble(averageColumns)}");