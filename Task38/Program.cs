// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] array = new double[size];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.NextDouble() * (max - min) + min;
}
return array;
}

string PrintArrayDouble(double[] arr)
{
    string array = ($"{Math.Round(arr[0],2)}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {Math.Round(arr[i],2)}" );
    }
    return array;
}

double Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max) max = arr[i];
    }
    for (int j = 0; j < arr.Length; j++)
    {
            if (arr[j]<min) min = arr[j];
    }
    double difference = max - min;
    return difference;
}

double[] array = CreateArrayRndDouble(5,-99,99);
double diff = Difference(array);
Console.WriteLine($"[{PrintArrayDouble(array)}] -> {Math.Round(diff,2)}");


