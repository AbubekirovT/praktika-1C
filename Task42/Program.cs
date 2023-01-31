// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DecimalToBinary(int num)
{
    int count = 1;
    int res = 0;
    while (num > 0)
    {
        res = res + num % 2 * count;
        num = num / 2;
        count = count * 10;
    }
    return res;
}

int result = DecimalToBinary(number);
Console.WriteLine(result);