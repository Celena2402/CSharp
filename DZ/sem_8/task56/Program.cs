/*
Задача 56: 
   Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
   суммой элементов.
*/

int[,] NewArray(int m, int n, int min, int max)
{
    int[,] array=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0;j<n;j++)
        {
            array[i,j]=new Random().Next(min,max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}


void SumMin(int[,] array)
{
    int minSum=0;
    int index=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
        }
        if (minSum>sum)
        {
            minSum=sum;
            index=i;
        }
        Console.WriteLine($"Сумма {i} строки = {sum}");
        minSum=sum;
    }
    Console.WriteLine();
    Console.WriteLine($"Индек строки с минимальной суммой = {index}");
    
}


Console.Write("Введите количество строк в массиве= ");
int m=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве= ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] array=NewArray(m,n,0,10);
PrintArray(array);
Console.WriteLine();
SumMin(array);

