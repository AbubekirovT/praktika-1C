// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int A, int B, int C)
{
    if (A < B + C && B < A + C && C < A + B) return true;
    else return false;
}

if (Triangle(number1, number2, number3)) Console.WriteLine("да");
else Console.WriteLine("нет");