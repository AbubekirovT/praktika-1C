// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номар четверти ");
string quarter = Console.ReadLine();
string Coordinates(string quar)
{
    if (quar == "1") return "x > 0, y > 0";
    if (quar == "2") return "x < 0, y > 0";
    if (quar == "3") return "x < 0, y < 0";
    if (quar == "4") return "x > 0, y < 0";
    return "Некорректный ввод";
}
string coordinates = Coordinates(quarter);
Console.WriteLine(coordinates);