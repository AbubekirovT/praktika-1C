// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

// int digit = first % second;
// if (digit == 0)
// {
//     Console.WriteLine($"{first} кратно {second}");
// }
// else
// {
//     Console.WriteLine($"остаток от деления {first} на {second} равен {digit}");
// }

int Digit(int num1,int num2)
{
    return num1 % num2;
}

if (Digit(first, second) == 0)
{
    Console.WriteLine($"{first} кратно {second}");
}
else
{
     Console.WriteLine($"остаток от деления {first} на {second} равен {Digit(first, second)}");
}