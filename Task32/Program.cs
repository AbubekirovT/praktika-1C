// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
        array = array + ($", {arr[i]}" );
    }
    return array;
}

int[] NumberSubstitution(int[] arr)
{
    int[] numberSubstitution = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0) numberSubstitution[i] = arr[i] * (-1);
    }
    return numberSubstitution;
}

int[] arr = GenerateArray(10,-9,9);
int[] arrNumberSubstitution = NumberSubstitution(arr);
Console.WriteLine($"[{PrintArray(arr)}] -> [{PrintArray(arrNumberSubstitution)}]");
