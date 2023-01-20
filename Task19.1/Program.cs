// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);
double reverse = 0;
int num = number;
int degree = 0;
while (num > 0)
{
    num = num / 10;
    degree++;
}
int count = 1;
while(degree > 0)
{
    reverse = reverse + Math.Round((number % Math.Pow(10,count))/Math.Pow(10,count-1),0,MidpointRounding.ToZero) * Math.Pow(10, (degree - 1));
    degree = degree - 1;
    count++;
}
if (number == reverse) Console.WriteLine($"Число {number} является палиндромом");
else Console.WriteLine($"Число {number} не является палиндромом");
