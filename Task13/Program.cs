// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0) number = number * (-1);
// if (number < 100) Console.WriteLine("третьей цифры нет");
// else
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//     Console.WriteLine(number % 10);
// }

int ThreeDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num;
}

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);
if (number < 100) Console.WriteLine("третьей цифры нет");
else Console.WriteLine(ThreeDigit(number) % 10);