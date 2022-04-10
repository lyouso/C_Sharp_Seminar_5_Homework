// На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго. 
// Ответ запишите в массив. 24, 132 -> {2, 6, 4, 4, 12, 8}

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int sum1 = GenerateArrayALength(a);
int sum2 = GenerateArrayBLength(b);
int[] ArrayA = new int[sum1];
int[] ArrayB = new int[sum2];
int[] NewArray = new int[sum1*sum2];
FillArrayA(a);
FillArrayB(b);
FillNewArray(NewArray);
PrintArray(NewArray);


int GenerateArrayALength(int a1)
{
    int sumArrayA = 0;
    while (a1 >= 1)
    {
        int remainder = a1%10;
        a1 /= 10;
        sumArrayA++;
    }
    return sumArrayA;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FillArrayA(int a2)
{
   int j = sum1-1;
    while (a2 >= 1)
    {
        ArrayA[j] = a2%10;
        a2 /= 10;
        j--;
    }
}

int GenerateArrayBLength(int b1)
{
    int sumArrayB = 0;
    while (b1 >= 1)
    {
        int remainder = b1%10;
        b1 /= 10;
        sumArrayB++;
    }
    return sumArrayB;
}

void FillArrayB(int b2)
{
   int j = sum2-1;
    while (b2 >= 1)
    {
        ArrayB[j] = b2%10;
        b2 /= 10;
        j--;
    }
}
void FillNewArray(int[] array)
{
   int i = 0; 
   while (i < NewArray.Length)
   {
       for (int j = 0; j < ArrayA.Length; j++)
       {
           for (int k = 0; k < ArrayB.Length; k++)
           {
               NewArray[i] = ArrayA[j] * ArrayB[k];
               i++;
           }
       }
   }
}
