﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Введите число");
// int digit = Convert.ToInt32(Console.ReadLine());
// if (digit % 7 ==0)
// {
//     if (digit % 23 == 0)
//     {
//         Console.WriteLine("Число кратно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число не кратно 23");
//     }
// }
// else
// {
//     Console.WriteLine("Число не кратно 7");
// }

Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());

bool Multiple(int dig)
{
    if (dig % 7 == 0 && dig % 23 == 0)
        return true;
    return false;
}
bool result = Multiple(digit);
if (result)
{
    Console.WriteLine($"Число {digit} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {digit} не кратно 7 и 23");
}
