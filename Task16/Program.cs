// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2*num2)
// {
//     Console.WriteLine($"{num1} является квадратом {num2}");
// }
// else if (num2 == num1*num1)
// {
//     Console.WriteLine($"{num2} является квадратом {num1}");
// }
// else
// {
//     Console.WriteLine("Данные числа не являются квадратами друг друга");
// }
// Лишние действия

bool Square(int number1, int number2)
{
    return number1 * number1 == number2 || number2 * number2 == number1;
}

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);

// if (result) Console.WriteLine("да");
// else Console.WriteLine("нет");
Console.WriteLine(result ? "да" : "нет");
