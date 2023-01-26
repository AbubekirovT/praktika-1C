// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB < 1) Console.WriteLine("Число В должно быть натуральным");
else
{
    int res = Exponentiation(numberA, numberB);
    Console.WriteLine($"{numberA} в степени {numberB} будет {res}");
}


int Exponentiation(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++) result = result * numA;
    return result;
}