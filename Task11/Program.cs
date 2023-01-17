// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int num = (firstDigit * 10) + thirdDigit;
// Console.WriteLine($"Из числа {number} получилось число {num}");


int FirstThirdDigits(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int res = (firstDigit * 10) + thirdDigit;
    return res;
}
int result = FirstThirdDigits(number);
Console.WriteLine($"Из числа {number} получилось число {result}");
