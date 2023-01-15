Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000 )
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последней цифрой числа {number} является {lastDigit}");
}
else if (number > -1000 && number < -99)
{
    int lastDigit = number % 10 *(-1);
    Console.WriteLine($"Последней цифрой числа {number} является {lastDigit}");
}
else
{
    Console.WriteLine("Введеное число не трехзначное");
}
