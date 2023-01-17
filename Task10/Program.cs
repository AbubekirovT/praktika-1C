// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);
if (number > 99 && number < 1000)
{
    int result = (number / 10) % 10;
    Console.WriteLine(result);
}
else Console.WriteLine("Число не трехзначное");

