// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ProductOfNumbers(int[] arr)
{
    int size = default;
    if (arr.Length % 2 == 0) size = arr.Length / 2;
    else size = arr.Length / 2 + 1;
    int[] productOfNumbers = new int[size];
    for (int i = 0; i < arr.Length / 2; i++) productOfNumbers[i] = arr[i] * arr[arr.Length - i - 1];
    if (arr.Length % 2 != 0) productOfNumbers[productOfNumbers.Length - 1] = arr[arr.Length / 2];

    return productOfNumbers;
}
int[] array = GenerateArray(7, 1, 9);
int[] res = ProductOfNumbers(array);
Console.WriteLine($"[{PrintArray(array)}] -> {PrintArray(res)}");


