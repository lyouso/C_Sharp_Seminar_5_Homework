// Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу, 
// которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.

int[] array = new int[15];
Generate(array);
PrintArray(array);
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt16(Console.ReadLine());
if (Determine(array)) Console.WriteLine($"Последовательность {number} есть в массиве");
else Console.WriteLine($"Последовательность {number} не существует в массиве");

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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
bool Determine(int[] array)
{
    int digit1 = number/100;
    int digit2 = number/10%10;
    int digit3 = number%10;

    for (int i = 0; i < array.Length; i++)
    {
        while (i+2 < array.Length)
        {
            if ((array[i] == digit1) & (array[i+1] == digit2) & (array[i+2] == digit3))
            {
                return true;
            }
            i++;
        }
    }
    return false;
}
    