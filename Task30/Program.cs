// int[] array = new int[8];
// int[] array1 = new int[8]{1,2,3,4,5,6,7,8};
// int[] array2 = {1,2,3};
// var array3 = new int[8];
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

var array = new int[8];
int[] FillArray(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{arr[i]}, ");

    }
}
array = FillArray(array);
PrintArray(array);