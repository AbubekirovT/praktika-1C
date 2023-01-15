Console.Write("Введите чесло: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int count = -number;

    while (count <= number)
    {
        Console.Write($"{count} ");
        count++; // ++ тоже самое что count = count +1
    }
}
else
{
    Console.WriteLine("Ошибка, введено отрицательное число");
}
