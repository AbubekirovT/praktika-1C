// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int NumberOfEvenNumbers(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) count++;
    }
    return count;
}

int[] array = GenerateArray(9,100,999);
int numberOfEvenNumbers = NumberOfEvenNumbers(array);
Console.WriteLine($"[{PrintArray(array)}] -> {numberOfEvenNumbers}");