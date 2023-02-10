// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1


int Ack(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = Ack(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}

Console.WriteLine("Введите два неотрицательных числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1<0 || number2<0) Console.WriteLine("Введены отрицательные числа");
else
{
int result = Ack(number1,number2);
Console.WriteLine(result);
}