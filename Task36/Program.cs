// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumOfOdd(int[] arr)
{
    int sum=default;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i%2!=0) sum += arr[i];
    }
    return sum;
}
int[] array = GenerateArray(4,-99,99);
int sumOfOdd = SumOfOdd(array);
Console.WriteLine($"[{PrintArray(array)}] -> {sumOfOdd}");