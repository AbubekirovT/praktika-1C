// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 1 || number > 7) Console.WriteLine("Неккоректное число");
// else
// {
//     if (number == 6 || number == 7) Console.WriteLine("Выходной");
//     else Console.WriteLine("Рабочий день");
// }


bool Day(int num)
{
    if (num == 6 || num == 7)
        return true;
    return false;
}

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7) Console.WriteLine("Неккоректное число");
else
{
    bool dayOff = Day(number);
    if (dayOff) Console.WriteLine("Выходной");
    else Console.WriteLine("Рабочий день");
}