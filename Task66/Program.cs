// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = default;
if (number1 < number2) sum = SumElements(number1, number2);
else sum = SumElements(number2, number1);
Console.WriteLine(sum);

int SumElements(int num1, int num2)
{
    if (num1 == num2) return num1;
    return num2 + SumElements(num1, num2 - 1);
}
