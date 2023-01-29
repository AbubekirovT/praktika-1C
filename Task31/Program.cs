// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int PositiveSum(int[] array)
{
    int positiveSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveSum = positiveSum + array[i];
    }
    return positiveSum;
}

int NegativeSum(int[] array)
{
    int negativeSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) negativeSum = negativeSum + array[i];
    }
    return negativeSum;
}

string PrintArray(int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}" );
    }
    return array;
}

int[] arr = GenerateArray(12, -9, 9);
int posSum = PositiveSum(arr);
int negSum = NegativeSum(arr);
Console.WriteLine($"Суммой положительных чисел массива [{PrintArray(arr)}] является число {posSum}");
Console.WriteLine($"Суммой отрицательных чисел массива [{PrintArray(arr)}] является число {negSum}");