// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[10];
Generate(array);
PrintArray(array);
Summ(array);

void Generate(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 10);
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
void Summ(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0) summ += array[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях, равна: " + summ);
}