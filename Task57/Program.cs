// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

string PrintArray(int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}");
    }
    return array;
}

int[] MatrixToArray(int[,] matrix)
{
    int count = 0;
    int[] array = new int[matrix.GetLength(1) * matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }

    }
    return array;
}

int[,] FrequencyDictionary(int[] array)
{
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != array[i - 1]) count++;
    }
    int[,] matrix = new int[count, 2];
    matrix[0, 0] = array[0];
    int j = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != array[i - 1])
        {
            matrix[j, 0] = array[i];
            j++;
        }
    }
    j = 0;
    int count2 = 1;
    for (int k = 1; k < array.Length; k++)
    {
        if (array[k] == array[k - 1])
        {
            count2++;
            if (k == array.Length - 1) matrix[j, 1] = count2;
        }
        else
        {
            matrix[j, 1] = count2;
            j++;
            count2 = 1;
        }

    }
    return matrix;
}

int[,] matrix2 = GenerateMatrix(3, 4, 0, 9);
PrintMatrix(matrix2);
int[] array2 = MatrixToArray(matrix2);
Console.WriteLine(PrintArray(array2));
Array.Sort(array2);
Console.WriteLine(PrintArray(array2));
int[,] matrix3 = FrequencyDictionary(array2);
PrintMatrix(matrix3);
