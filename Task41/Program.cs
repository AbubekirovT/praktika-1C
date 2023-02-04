// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

string PrintArray(int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}");
    }
    return array;
}

int NumberOfPositiveNumbers(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[amount];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Введите число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int posNumbers = NumberOfPositiveNumbers(arr);


Console.WriteLine($"Массив {PrintArray(arr)} содержит {posNumbers} положительных чисел");
