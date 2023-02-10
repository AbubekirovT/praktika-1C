// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 0) number = number * (-1);
int summ = SumOfDigits2(number);
Console.WriteLine(summ);


// int SumOfDigits(int num)
// {
//     int sum = default;
//     if (num > 9)
//     {
//         sum = SumOfDigits(num / 10) + num % 10;
//         return sum;
//     }
//     else
//         return num;
// }

int SumOfDigits2(int num)
{
    if (num < 10) return num;
    else return num % 10 + SumOfDigits2(num / 10);
}



