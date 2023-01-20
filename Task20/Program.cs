// Math.Pow(2, 10);
// Math.Sqrt(5);
// double d = 5.09997623455;
// double dRuynd = Math.Round(d, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRuynd);

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты A1: ");
Console.Write("x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты A2: ");
Console.Write("x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

double Distance(double xa,double ya,double xb,double yb)
{
    return  Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb));
}
double distance = Distance(x1,y1,x2,y2);
Console.WriteLine(Math.Round(distance,2,MidpointRounding.ToZero));