/*
Задача 33: (seminar_1/sem_5/Task33)
     Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
      4; массив [6, 7, 19, 345, 3] -> нет
     -3; массив [6, 7, 19, 345, 3] -> да
     */


int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res=new int[size];
    for (int i=0; i<size;i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array=GetArray(12,-9,9);
Console.WriteLine();

int[] array1=new int[array.Length];

Console.WriteLine("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());

for (int i=0; i<=array.Length;i++)
{
    if (array1[i]!=num)
    {
        Console.WriteLine($"Это число {num} есть в массива");
        break;
    }
    else
    {
        Console.WriteLine($"Такого числа {num} нет в массиве");
        break;
    }
}