// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


bool Presence(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = { 6, 7, 19, 345, 3 };

if(Presence(num,array)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

