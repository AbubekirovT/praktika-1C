// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number*(-1);
if (number > 100000 || number < 10000) Console.WriteLine("Некорректный ввод");
else Palindrome(number);


void Palindrome(int num)
{
    if (num/10000 == num%10 && (num/1000)%10 == (num%100)/10)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}