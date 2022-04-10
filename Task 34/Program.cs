// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
int[] array = new int[10];
Generate(array);
PrintArray(array);
EvenNumber(array);

void Generate(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if( array[i] % 2 == 0) count ++;
    }
    Console.WriteLine("Количество четных чисел в массиве равно " + count);
}