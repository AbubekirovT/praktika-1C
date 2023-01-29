// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

string PrintArray(int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}");
    }
    return array;
}

int Quantity(int[] arr, int min, int max)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) count++;
    }
    return count;
}
int[] array = GenerateArray(123, 0,999);
int res = Quantity(array,10,99);
Console.WriteLine($"[{PrintArray(array)}] -> {res}");