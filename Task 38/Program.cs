// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] array = new double[5];
Generate(array);
PrintArray(array);
Console.WriteLine("Минимальное число в массиве равно: " + Min(array));
Console.WriteLine("Максимальное число в массиве равно: " + Max(array));
double difference = Max(array) - Min(array);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + difference);


void Generate(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 10);
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
double Min(double[] array)
{
    double min = 0;
    for (int i = 0; i < (array.Length - 1); i++)
    {
        min = array[i];
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < min) min = array[j];
        }
    }
    return min;
}
double Max(double[] array)
{
    double max = 0;
    for (int i = 0; i < (array.Length -1); i++)
    {
        max = array[i];
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > max) max = array[j];
        }
    }
    return max;
}