// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты A1: ");
Console.Write("x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты A2: ");
Console.Write("x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb)+ (za -zb)*(za-zb));
}
double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));