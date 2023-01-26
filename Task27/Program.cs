// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0) Console.WriteLine("Сумма цифр числа 0 равно 0");
else if (number < 0) number = number * (-1);
int sum = SumOfDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равно {sum}");


int SumOfDigits(int num)
{
    int sumOfDigits = 0;
    while (num > 0)
    {
        sumOfDigits = sumOfDigits + num % 10;
        num = num / 10;
    }
    return sumOfDigits;
}
